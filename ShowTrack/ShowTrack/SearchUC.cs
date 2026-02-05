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
    public partial class SearchUC : UserControl
    {
        private User user;
        public SearchUC()
        {
            InitializeComponent();
            LoadUser();
        }

        private void LoadUser()
        {
            var user = UserSession.CurrentUser;
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = SearchTextBox.Text.Trim();
            if(string.IsNullOrEmpty(query)) { return; }
        
            MovieApiService api = new MovieApiService();

            var result = await api.SearchMediaAsync(query);

            ResultPanel.Controls.Clear();

            foreach (var movie in result)
            {
                MovieDetailsRectangleUC card = new MovieDetailsRectangleUC();

                card.SetData(movie);

                ResultPanel.Controls.Add(card);
            }
        }
    }
}
