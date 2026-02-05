using System;
using System.Collections.Generic;
using System.Text;
using ShowTrack.Entity;

namespace ShowTrack.DataAccess
{
    internal class MailLogRepository : IMailLogRepository
    {
        private readonly ShowTrackContext _context = new ShowTrackContext();

        public void AddLog(MailLog log)
        {
            _context.MailLog.Add(log);
            _context.SaveChanges();
        }

        public void DeleteByEmail(string email)
        {
            _context.MailLog.RemoveRange(_context.MailLog.Where(x => x.EmailAddress == email));
            _context.SaveChanges();
        }

        public MailLog? GetLastCodeByEmail(string email)
        {
            return _context.MailLog
                .Where(x => x.EmailAddress == email)
                .OrderByDescending(x => x.Id)
                .FirstOrDefault();
        }
    }
}
