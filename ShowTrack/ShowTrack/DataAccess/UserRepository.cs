using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShowTrack.Entity;

namespace ShowTrack.DataAccess
{
    internal class UserRepository : IUserRepository
    {
        private readonly ShowTrackContext _context = new ShowTrackContext();
        public void Add(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }
        }

        public void UpdatePassword(int userId, string newPasswordHash)
        {
            var user = GetById(userId);
            if (user != null)
            {
                user.Password = newPasswordHash;
                _context.SaveChanges();
            }
        }

        public User? GetByEmail(string email)
        {
            return _context.User.FirstOrDefault(u => u.Email == email);
        }

        public User? GetById(int id)
        {
            return _context.User.Find(id);
        }

        public bool IsEmailAvailable(string email)
        {
            return !_context.User.Any(u => u.Email == email);
        }

        public bool IsUsernameAvailable(string username)
        {
            return !_context.User.Any(u => u.Username == username);
        }

        public User? Login(string EmailOrUsername, string passwordHash)
        {
            return _context.User.FirstOrDefault(u => 
                (u.Email == EmailOrUsername || u.Username == EmailOrUsername) 
                && u.Password == passwordHash);
        }

        public void Update(User user)
        {
            _context.User.Update(user);
            _context.SaveChanges();
        }
    }
}
