using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShowTrack.DataAccess;

namespace ShowTrack
{
    public partial class ProfileUC : UserControl
    {
        //TODO: Implement extra usercontrols for changing password and updating profile information
        public ProfileUC()
        {
            InitializeComponent();
            LoadUser();
        }

        private void LoadUser()
        {
            var user = UserSession.CurrentUser;

            if (user != null)
            {
                UsernameLabel.Text = "Welcome, " + user.Username;
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.CurrentUser = null;
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.FindForm().Close();
            }
        }

        private void ProfileUC_Load(object sender, EventArgs e)
        {
        }

    }
}
