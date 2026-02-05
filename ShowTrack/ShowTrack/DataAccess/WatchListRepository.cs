using System;
using System.Collections.Generic;
using System.Text;
using ShowTrack.Entity;

namespace ShowTrack.DataAccess
{
    public class WatchListRepository : IWatchListRepository
    {
        ShowTrackContext _context = new ShowTrackContext();
        public void addToWatchList(int userId, string showId)
        {
            _context.WatchList.Add(new WatchList
            {
                UserId = userId,
                ImdbId = showId.ToString()
            });
            _context.SaveChanges();
        }

        public List<string> getWatchListByUserId(int userId)
        {
            List<string> list = _context.WatchList
                .Where(x => x.UserId == userId)
                .Select(x => x.ImdbId)
                .ToList();

            return list;
        }

        public void removeFromWatchList(int userId, string showId)
        {
            _context.WatchList.RemoveRange(_context.WatchList.Where
                (x => x.UserId == userId && x.ImdbId == showId.ToString()));
            _context.SaveChanges();
        }

        public bool isInWatchList(int userId, string showId)
        {
            return _context.WatchList.Any(x => x.UserId == userId && x.ImdbId == showId.ToString());
        }
    }
}
