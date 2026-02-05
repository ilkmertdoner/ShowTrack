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
    public partial class CodeForm : Form
    {
        private int _remaningAttempts = 3;
        private User _UserData;
        private MailService _MailService;
        public CodeForm(User user)
        {
            InitializeComponent();
            _UserData = user;
            _MailService = new MailService(new MailLogRepository());
        }

        private void CheckCodeButton_Click(object sender, EventArgs e)
        {
            if(_MailService.Verify(_UserData.Email, CodeTextBox.Text))
            {
                var repo = new UserRepository();
                repo.Add(_UserData);

                _MailService.Delete(_UserData.Email);
                MessageBox.Show("Code Is Correct! Now You Can Sign In");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _remaningAttempts--;
                if(_remaningAttempts > 0)
                {
                    Attempts.Text = ($"Wrong Code! Remaning Attempts: {_remaningAttempts}");
                }
                else
                {
                    _MailService.Delete(_UserData.Email);
                    MessageBox.Show("You Have Zero Remaning Attempts. Returning To The Login Form");
                    this.DialogResult= DialogResult.Abort;
                    this.Close();
                }
            }
        }
    }
}
