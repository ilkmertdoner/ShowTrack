using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using ShowTrack.DataAccess;

namespace ShowTrack.Business
{
    public class ListService
    {
        private readonly IWatchListRepository _watchListRepository;

        public ListService(IWatchListRepository watchListRepository)
        {
            _watchListRepository = watchListRepository;
        }

        public void AddToWatchList(int userId, string imdbId)
        {
            if (string.IsNullOrEmpty(userId.ToString()) || string.IsNullOrEmpty(imdbId.ToString()))
            {
                MessageBox.Show("Succesfully Added To List", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            _watchListRepository.addToWatchList(userId, imdbId);
        }

        public void RemoveFromWatchList(int userId, string imdbId)
        {
            if (string.IsNullOrEmpty(userId.ToString()) || string.IsNullOrEmpty(imdbId))
            {
                MessageBox.Show("User ID and Media ID cannot be null or empty.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _watchListRepository.removeFromWatchList(userId, imdbId);
        }
    }
}
