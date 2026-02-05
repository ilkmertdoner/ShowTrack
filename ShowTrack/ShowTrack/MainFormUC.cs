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
    public partial class MainFormUC : UserControl
    {
        private User user;
        public MainFormUC()
        {
            InitializeComponent();
            user = UserSession.CurrentUser;
        }

        private void MainFormUC_Load(object sender, EventArgs e)
        {
            loadTop6MovieToPanel();
            loadTop6SeriesToPanel();
        }

        private async void loadTop6MovieToPanel()
        {
            MovieApiService api = new MovieApiService();
            var top6Movies = await api.GetTop6ByRankAsync("movie");
            MoviePanel.Controls.Clear();

            foreach (var movie in top6Movies)
            {
                var card = new MovieDetailsSquareUC();
                card.SetData(movie);
                MoviePanel.Controls.Add(card);
            }
        }

        private async void loadTop6SeriesToPanel()
        {
            MovieApiService api = new MovieApiService();
            var top6Series = await api.GetTop6ByRankAsync("series");
            SeriesPanel.Controls.Clear();

            foreach (var tvShow in top6Series)
            {
                var card = new MovieDetailsSquareUC();
                card.SetData(tvShow);
                SeriesPanel.Controls.Add(card);
            }
        }
    }
}
