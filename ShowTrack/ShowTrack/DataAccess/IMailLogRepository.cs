using System;
using System.Collections.Generic;
using System.Text;
using ShowTrack.Entity;

namespace ShowTrack.DataAccess
{
    public interface IMailLogRepository
    {
        void AddLog(MailLog log);
        void DeleteByEmail(string email);
        MailLog? GetLastCodeByEmail(string email);
    }
}
