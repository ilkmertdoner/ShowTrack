using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShowTrack.Business;
using ShowTrack.DataAccess;
using ShowTrack.Entity;

namespace ShowTrack
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var _userService = new UserService(repo);

            User newUser = new User
            {
                Username = UsernameTextBox.Text,
                Email = EmailTextBox.Text,
                Password = PasswordTextBox.Text,
                AccountCreateDate = DateTime.Now
            };

            string result = _userService.Register(newUser, ConfirmPasswordTextBox.Text);

            if (result == "Registration successful.")
            {
                var _mailLogService = new MailService(new MailLogRepository());
                string CodeResult = _mailLogService.SendVerificationCode(newUser.Email);

                if (CodeResult == "Success")
                {
                    MessageBox.Show("Please enter the 6-digit code we sent to your email.",
                        "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (var verifyForm = new CodeForm(newUser))
                    {
                        if (verifyForm.ShowDialog() == DialogResult.OK)
                        {
                            LoginForm login = new LoginForm();
                            login.Show();
                            this.Close();
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Failed To Send Verification Code. Please Try Again Later. Details: " +
                        CodeResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show(result, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var loginForm = new LoginForm())
            {
                loginForm.ShowDialog();
            }
            this.Close();
        }
    }
}
