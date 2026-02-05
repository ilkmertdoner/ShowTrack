using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ShowTrack.Business;
using ShowTrack.DataAccess;
using ShowTrack.Entity;

namespace ShowTrack
{
    public partial class DetailsUC : UserControl
    {
        private int UserId;
        private string ImdbID;
        private string ImdbUrl;

        public DetailsUC()
        {
            InitializeComponent();
            UserId = UserSession.CurrentUser?.Id ?? 0;
        }

        public void SetData(MovieDescription movie)
        {
            MovieNameLabel.Text = movie.title;
            YearLabel.Text = "Release Date: " + movie.year.ToString();
            AKALabel.Text = "Aka: " + movie.aka;
            RankLabel.Text = "Rank: #" + movie.rank.ToString();
            ActorsLabel.Text = "Actors: " + string.Join(", ", movie.actors);
            ImdbID = movie.imdb_id;
            ImdbUrl = movie.imdb_url;

            if (movie.img_url != null)
            {
                MoviePictureBox.LoadAsync(movie.img_url);
                MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void DetailsUC_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            var repo = new WatchListRepository();
            ListService listService = new ListService(repo);
            var isinWatchList = repo.isInWatchList(UserId, ImdbID);

            if (isinWatchList)
            {
                listService.RemoveFromWatchList(UserId, ImdbID);
                MessageBox.Show("Removed From The List", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listService.AddToWatchList(UserId, ImdbID);
                MessageBox.Show("Added To The List", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            RefreshUI();
        }

        private void GoToImdbButton_Click(object sender, EventArgs e)
        {
            GoToUrl(ImdbUrl);
        }

        private void GoToUrl(string url)
        {
            try
            {
                if (!string.IsNullOrEmpty(url))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the link. " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshUI()
        {
            var repo = new WatchListRepository();
            bool isinWatchList = repo.isInWatchList(UserId, ImdbID);

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
    }
}
