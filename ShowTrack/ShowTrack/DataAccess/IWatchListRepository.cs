using System;
using System.Collections.Generic;
using System.Text;

namespace ShowTrack.DataAccess
{
    public interface IWatchListRepository
    {
        void addToWatchList(int userId, string showId);
        void removeFromWatchList(int userId, string showId);
        List<string> getWatchListByUserId(int userId);
    }
}
