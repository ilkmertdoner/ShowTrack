using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShowTrack.DataAccess;
using ShowTrack.Entity;
using ShowTrack.Business;

namespace ShowTrack
{
    public partial class MovieDetailsRectangleUC : UserControl
    {
        private int UserId;
        private MovieDescription MovieDetails;

        public MovieDetailsRectangleUC()
        {
            InitializeComponent();
            UserId = UserSession.CurrentUser?.Id ?? 0;
        }

        public void SetData(MovieDescription movie)
        {
            MovieNameLabel.Text = movie.title;
            ReleaseDateLabel.Text = "Released Date: " + movie.year.ToString();
            MovieDetails = movie;

            if (!string.IsNullOrEmpty(movie.img_url))
            {
                MoviePictureBox.LoadAsync(movie.img_url);
                MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            RefreshUI();
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            var repo = new WatchListRepository();
            ListService listService = new ListService(repo);
            bool isinWatchList = repo.isInWatchList(UserId, MovieDetails.imdb_id);

            if (isinWatchList)
            {
                listService.RemoveFromWatchList(UserId, MovieDetails.imdb_id);
                MessageBox.Show("Removed From The List", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listService.AddToWatchList(UserId, MovieDetails.imdb_id);
                MessageBox.Show("Added To The List", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AddToListButton.Text = "Add to Watch List";
                AddToListButton.FillColor = Color.FromArgb(70, 70, 70);
            }

        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {
            var DetailsUC = new DetailsUC();
            DetailsUC.SetData(MovieDetails);

            MainForm.Instance.ShowControl(DetailsUC);
        }
    }
}
