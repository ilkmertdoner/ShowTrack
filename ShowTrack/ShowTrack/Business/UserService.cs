using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using ShowTrack.DataAccess;
using ShowTrack.Entity;

namespace ShowTrack.Business
{
    internal class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? LoginControl(string EmailOrUsername, string passwordHash)
        {
            if (string.IsNullOrEmpty(EmailOrUsername) || string.IsNullOrEmpty(passwordHash)) return null;

            return _userRepository.Login(EmailOrUsername, passwordHash);
        }

        public bool UpdateUsername(int id, string newUsername)
        {
            var user = _userRepository.GetById(id);

            if (user != null && _userRepository.IsUsernameAvailable(newUsername))
            {
                user.Username = newUsername;
                _userRepository.Update(user);
                return true;
            }

            return false;
        }

        public string Register(User user, string ConfirmPassword)
        {
            if (!(IsValidEmail(user.Email))) return "Invalid email format.";

            if (!(_userRepository.IsEmailAvailable(user.Email))) return "Email is already registered.";

            if (!(_userRepository.IsUsernameAvailable(user.Username))) return "Username is already taken.";

            if (string.IsNullOrEmpty(user.Username)) return "Username cannot be empty.";

            if (user.Password.Length < 6) return "Password must be at least 6 characters long.";

            if (user.Password != ConfirmPassword) return "Passwords do not match.";

            return "Registration successful.";
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            return Regex.IsMatch(email, pattern);
        }

        public bool ChangePasswordControl(int userId, string EmailorPassword,string newPassword, string confirmPassword)
        {
            if(userId == 0) return false;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword) || 
                string.IsNullOrEmpty(EmailorPassword)) { return false; }

            {
                MessageBox.Show("Password fields cannot be empty.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if(newPassword.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            
            if (!(newPassword == confirmPassword))
            {
                MessageBox.Show("Passwords do not match.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

