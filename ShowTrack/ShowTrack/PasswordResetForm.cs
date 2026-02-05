using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ShowTrack.Business;
using ShowTrack.DataAccess;

namespace ShowTrack
{
    public partial class PasswordResetForm : Form
    {
        UserRepository _User = new UserRepository();
        public PasswordResetForm()
        {
            InitializeComponent();
        }

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(EmailTextBox.Text)))
            {
                var user = _User.GetByEmail(EmailTextBox.Text);

                if (user != null)
                {
                    var _mailLogService = new MailService(new MailLogRepository());
                    string CodeResult = _mailLogService.SendVerificationCode(user.Email, user.Id);

                    MessageBox.Show("Please Enter The Code That We Sent Your Email",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (CodeResult == "Success")
                    {
                        using (var verifyForm = new CodeForm(user))
                        {
                            if (verifyForm.ShowDialog() == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Failed To Send Verification Code. Please Try Again Later.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("No Account Found With This Email", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
