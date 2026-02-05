using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShowTrack.DataAccess;
using ShowTrack.Entity;

namespace ShowTrack
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;
        public MainForm(User User)
        {
            InitializeComponent();
            UserSession.CurrentUser = User;
            Instance = this;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ShowControl(new ProfileUC());
        }

        public void ShowControl(UserControl content)
        {
            MainPanel.Controls.Clear();

            content.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(content);
            content.BringToFront();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ShowControl(new SearchUC());
        }

        private void MyListButton_Click(object sender, EventArgs e)
        {
            ShowControl(new MyListUC());
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ShowControl(new MainFormUC());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowControl(new MainFormUC());
        }
    }
}
