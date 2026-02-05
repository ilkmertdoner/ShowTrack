namespace ShowTrack
{
    partial class MovieDetailsSquareUC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            MovieNameLabel = new Label();
            MoviePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            DetailsButton = new Guna.UI2.WinForms.Guna2Button();
            AddToListButton = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(MovieNameLabel);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(227, 37);
            guna2Panel1.TabIndex = 1;
            // 
            // MovieNameLabel
            // 
            MovieNameLabel.AutoEllipsis = true;
            MovieNameLabel.Dock = DockStyle.Left;
            MovieNameLabel.Font = new Font("Segoe UI", 11F);
            MovieNameLabel.ForeColor = SystemColors.Control;
            MovieNameLabel.Location = new Point(0, 0);
            MovieNameLabel.Name = "MovieNameLabel";
            MovieNameLabel.Size = new Size(228, 37);
            MovieNameLabel.TabIndex = 0;
            MovieNameLabel.Text = "label1";
            MovieNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MoviePictureBox
            // 
            MoviePictureBox.BackColor = Color.Transparent;
            MoviePictureBox.CustomizableEdges = customizableEdges3;
            MoviePictureBox.FillColor = Color.Transparent;
            MoviePictureBox.ImageRotate = 0F;
            MoviePictureBox.Location = new Point(0, 41);
            MoviePictureBox.Name = "MoviePictureBox";
            MoviePictureBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            MoviePictureBox.Size = new Size(226, 143);
            MoviePictureBox.TabIndex = 2;
            MoviePictureBox.TabStop = false;
            // 
            // DetailsButton
            // 
            DetailsButton.AutoRoundedCorners = true;
            DetailsButton.BackColor = Color.Transparent;
            DetailsButton.CustomizableEdges = customizableEdges5;
            DetailsButton.DisabledState.BorderColor = Color.DarkGray;
            DetailsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            DetailsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DetailsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DetailsButton.FillColor = Color.FromArgb(70, 70, 70);
            DetailsButton.Font = new Font("Segoe UI", 11F);
            DetailsButton.ForeColor = Color.White;
            DetailsButton.Location = new Point(5, 190);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DetailsButton.Size = new Size(106, 45);
            DetailsButton.TabIndex = 3;
            DetailsButton.Text = "Details";
            DetailsButton.Click += DetailsButton_Click;
            // 
            // AddToListButton
            // 
            AddToListButton.AutoRoundedCorners = true;
            AddToListButton.BackColor = Color.Transparent;
            AddToListButton.CustomizableEdges = customizableEdges7;
            AddToListButton.DisabledState.BorderColor = Color.DarkGray;
            AddToListButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddToListButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddToListButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddToListButton.FillColor = Color.FromArgb(70, 70, 70);
            AddToListButton.Font = new Font("Segoe UI", 8F);
            AddToListButton.ForeColor = Color.White;
            AddToListButton.Location = new Point(117, 190);
            AddToListButton.Name = "AddToListButton";
            AddToListButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddToListButton.Size = new Size(106, 45);
            AddToListButton.TabIndex = 3;
            AddToListButton.Text = "Add To List";
            AddToListButton.Click += AddToListButton_Click;
            // 
            // MovieDetailsSquareUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(AddToListButton);
            Controls.Add(DetailsButton);
            Controls.Add(MoviePictureBox);
            Controls.Add(guna2Panel1);
            Margin = new Padding(5, 3, 3, 3);
            Name = "MovieDetailsSquareUC";
            Size = new Size(227, 241);
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox MoviePictureBox;
        private Guna.UI2.WinForms.Guna2Button DetailsButton;
        private Guna.UI2.WinForms.Guna2Button AddToListButton;
        private Label MovieNameLabel;
    }
}
