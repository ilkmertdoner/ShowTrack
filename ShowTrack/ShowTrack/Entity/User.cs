using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using System.Text;

namespace ShowTrack.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime AccountCreateDate { get; set; }

        public virtual ICollection<MailLog> MailLog { get; set; }
        public virtual ICollection<WatchList> Watchlist { get; set;}
    }
}
