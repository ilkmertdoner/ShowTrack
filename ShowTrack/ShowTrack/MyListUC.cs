using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShowTrack.Business;
using ShowTrack.DataAccess;
using ShowTrack.Entity;

namespace ShowTrack
{
    public partial class MyListUC : UserControl
    {
        private User user;
        public MyListUC()
        {
            InitializeComponent();
            user = UserSession.CurrentUser;
        }

        private async void MyListUC_Load(object sender, EventArgs e)
        {
            ResultPanel.Controls.Clear();

            var repo = new WatchListRepository();
            List<string> imdbIds = repo.getWatchListByUserId(user.Id);
            
            MovieApiService api = new MovieApiService();
            
            foreach(string id in imdbIds)
            {
                var movie = await api.GetMovieByIdAsync(id);

                if(movie != null && !string.IsNullOrEmpty(movie.title))
                {
                    var card = new MovieDetailsRectangleUC();
                    card.SetData(movie);
                    ResultPanel.Controls.Add(card);
                }
            }
        }
    }
}
