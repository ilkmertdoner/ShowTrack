using System;
using System.Collections.Generic;
using System.Text;
using ShowTrack.Entity;

namespace ShowTrack.DataAccess
{
    public class UserSession
    {
        public static User? CurrentUser { get; set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static void Logout() { CurrentUser = null; }

    }
}
