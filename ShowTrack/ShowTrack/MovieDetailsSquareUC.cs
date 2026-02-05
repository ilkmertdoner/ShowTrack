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
    public partial class MovieDetailsSquareUC : UserControl
    {
        private int UserId;
        private MovieDescription MovieDetails;
        public MovieDetailsSquareUC()
        {
            InitializeComponent();
            UserId = UserSession.CurrentUser?.Id ?? 0;
        }

        public void SetData(MovieDescription movie)
        {
            MovieNameLabel.Text = movie.title;
            MovieDetails = movie;

            if (movie.img_url != null)
            {
                MoviePictureBox.LoadAsync(movie.img_url);
                MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            RefreshUI();
        }

        private void RefreshUI()
        {
            var repo = new WatchListRepository();
            bool isinWatchList = repo.isInWatchList(UserId, MovieDetails.imdb_id);
            
            if (isinWatchList)
            {
                AddToListButton.Text = "Remove From List";
                AddToListButton.FillColor = Color.Gray;
            }
            else
            {
                AddToListButton.Text = "Add To List";
                AddToListButton.FillColor = Color.FromArgb(70, 70, 70);
            }
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            var repo = new WatchListRepository();
            bool isinWatchList = repo.isInWatchList(UserId, MovieDetails.imdb_id);

            if (isinWatchList)
            {
                MessageBox.Show("Removing from Watch List");
                repo.removeFromWatchList(UserId, MovieDetails.imdb_id);
                RefreshUI();
            }
            else
            {
                MessageBox.Show("Adding to Watch List");
                repo.addToWatchList(UserId, MovieDetails.imdb_id);
                RefreshUI();
            }
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            var detailsUc = new DetailsUC();
            detailsUc.SetData(MovieDetails);

            MainForm.Instance.ShowControl(detailsUc);
        }
    }
}
