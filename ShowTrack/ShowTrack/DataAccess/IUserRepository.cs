using System;
using System.Collections.Generic;
using System.Text;
using ShowTrack.Entity;

namespace ShowTrack.DataAccess
{
    internal interface IUserRepository
    {
        User? GetById(int id);
        User? GetByEmail(string email);
        User? Login(string EmailOrUsername, string passwordHash);
        bool IsEmailAvailable(string email);
        bool IsUsernameAvailable(string username);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
