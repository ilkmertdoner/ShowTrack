namespace ShowTrack
{
    partial class ProfileUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ProfileUCPanel = new Guna.UI2.WinForms.Guna2Panel();
            LogoutButton = new Guna.UI2.WinForms.Guna2ImageButton();
            UsernameLabel = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ChangePasswordPanel = new Guna.UI2.WinForms.Guna2Panel();
            ProfileUCPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ProfileUCPanel
            // 
            ProfileUCPanel.Controls.Add(LogoutButton);
            ProfileUCPanel.Controls.Add(UsernameLabel);
            ProfileUCPanel.Controls.Add(guna2Separator1);
            ProfileUCPanel.Controls.Add(guna2CirclePictureBox1);
            ProfileUCPanel.Controls.Add(ChangePasswordPanel);
            ProfileUCPanel.CustomizableEdges = customizableEdges5;
            ProfileUCPanel.Dock = DockStyle.Fill;
            ProfileUCPanel.FillColor = Color.FromArgb(35, 35, 35);
            ProfileUCPanel.Location = new Point(0, 0);
            ProfileUCPanel.Name = "ProfileUCPanel";
            ProfileUCPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ProfileUCPanel.Size = new Size(1491, 804);
            ProfileUCPanel.TabIndex = 0;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.Transparent;
            LogoutButton.BackgroundImage = Properties.Resources.logout;
            LogoutButton.BackgroundImageLayout = ImageLayout.Zoom;
            LogoutButton.CheckedState.ImageSize = new Size(64, 64);
            LogoutButton.HoverState.ImageSize = new Size(64, 64);
            LogoutButton.ImageOffset = new Point(0, 0);
            LogoutButton.ImageRotate = 0F;
            LogoutButton.ImageSize = new Size(0, 0);
            LogoutButton.Location = new Point(1395, 122);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.PressedState.ImageSize = new Size(64, 64);
            LogoutButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            LogoutButton.Size = new Size(52, 37);
            LogoutButton.TabIndex = 7;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 25F);
            UsernameLabel.ForeColor = SystemColors.ButtonHighlight;
            UsernameLabel.Location = new Point(212, 112);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(301, 57);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Welcome, User";
            // 
            // guna2Separator1
            // 
            guna2Separator1.BackColor = Color.Transparent;
            guna2Separator1.Location = new Point(45, 199);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1402, 12);
            guna2Separator1.TabIndex = 1;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.BackgroundImage = Properties.Resources.user;
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2CirclePictureBox1.FillColor = Color.Transparent;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(45, 36);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(144, 133);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // ChangePasswordPanel
            // 
            ChangePasswordPanel.AutoScroll = true;
            ChangePasswordPanel.CustomizableEdges = customizableEdges3;
            ChangePasswordPanel.FillColor = Color.FromArgb(40, 40, 40);
            ChangePasswordPanel.Location = new Point(45, 217);
            ChangePasswordPanel.Name = "ChangePasswordPanel";
            ChangePasswordPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ChangePasswordPanel.Size = new Size(1402, 574);
            ChangePasswordPanel.TabIndex = 5;
            // 
            // ProfileUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProfileUCPanel);
            Name = "ProfileUC";
            Size = new Size(1491, 804);
            Load += ProfileUC_Load;
            ProfileUCPanel.ResumeLayout(false);
            ProfileUCPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ProfileUCPanel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label UsernameLabel;
        private Guna.UI2.WinForms.Guna2Panel ChangePasswordPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ImageButton LogoutButton;
    }
}
