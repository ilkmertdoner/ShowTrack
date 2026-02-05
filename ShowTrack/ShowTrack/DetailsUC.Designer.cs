namespace ShowTrack
{
    partial class DetailsUC
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
            DetailsPanel = new Panel();
            RankLabel = new Label();
            AddToListButton = new Guna.UI2.WinForms.Guna2Button();
            GoToImdbButton = new Guna.UI2.WinForms.Guna2Button();
            DescriptionPanel = new Panel();
            guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            MovieNameLabel = new Label();
            ActorsLabel = new Label();
            YearLabel = new Label();
            AKALabel = new Label();
            MoviePictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            DetailsPanel.SuspendLayout();
            DescriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).BeginInit();
            SuspendLayout();
            // 
            // DetailsPanel
            // 
            DetailsPanel.BackColor = Color.FromArgb(35, 35, 35);
            DetailsPanel.Controls.Add(RankLabel);
            DetailsPanel.Controls.Add(AddToListButton);
            DetailsPanel.Controls.Add(GoToImdbButton);
            DetailsPanel.Controls.Add(DescriptionPanel);
            DetailsPanel.Controls.Add(MoviePictureBox);
            DetailsPanel.Dock = DockStyle.Fill;
            DetailsPanel.Location = new Point(0, 0);
            DetailsPanel.Name = "DetailsPanel";
            DetailsPanel.Size = new Size(1491, 806);
            DetailsPanel.TabIndex = 0;
            // 
            // RankLabel
            // 
            RankLabel.Font = new Font("Segoe UI", 15F);
            RankLabel.ForeColor = SystemColors.Control;
            RankLabel.Location = new Point(74, 179);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new Size(152, 41);
            RankLabel.TabIndex = 1;
            RankLabel.Text = "Rank";
            // 
            // AddToListButton
            // 
            AddToListButton.BackColor = Color.FromArgb(65, 65, 65);
            AddToListButton.BorderColor = Color.Transparent;
            AddToListButton.CustomizableEdges = customizableEdges1;
            AddToListButton.DisabledState.BorderColor = Color.DarkGray;
            AddToListButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddToListButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddToListButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddToListButton.FillColor = Color.FromArgb(65, 65, 65);
            AddToListButton.Font = new Font("Segoe UI", 15F);
            AddToListButton.ForeColor = Color.White;
            AddToListButton.Location = new Point(767, 518);
            AddToListButton.Name = "AddToListButton";
            AddToListButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddToListButton.Size = new Size(650, 65);
            AddToListButton.TabIndex = 3;
            AddToListButton.Text = "Add To List";
            AddToListButton.Click += AddToListButton_Click;
            // 
            // GoToImdbButton
            // 
            GoToImdbButton.BackColor = Color.FromArgb(65, 65, 65);
            GoToImdbButton.BorderColor = Color.Transparent;
            GoToImdbButton.CustomizableEdges = customizableEdges3;
            GoToImdbButton.DisabledState.BorderColor = Color.DarkGray;
            GoToImdbButton.DisabledState.CustomBorderColor = Color.DarkGray;
            GoToImdbButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GoToImdbButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GoToImdbButton.FillColor = Color.FromArgb(65, 65, 65);
            GoToImdbButton.Font = new Font("Segoe UI", 15F);
            GoToImdbButton.ForeColor = Color.White;
            GoToImdbButton.Location = new Point(74, 518);
            GoToImdbButton.Name = "GoToImdbButton";
            GoToImdbButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            GoToImdbButton.Size = new Size(650, 65);
            GoToImdbButton.TabIndex = 3;
            GoToImdbButton.Text = "Go To Imdb Site";
            GoToImdbButton.Click += GoToImdbButton_Click;
            // 
            // DescriptionPanel
            // 
            DescriptionPanel.Controls.Add(guna2Separator4);
            DescriptionPanel.Controls.Add(guna2Separator3);
            DescriptionPanel.Controls.Add(guna2Separator2);
            DescriptionPanel.Controls.Add(guna2Separator1);
            DescriptionPanel.Controls.Add(MovieNameLabel);
            DescriptionPanel.Controls.Add(ActorsLabel);
            DescriptionPanel.Controls.Add(YearLabel);
            DescriptionPanel.Controls.Add(AKALabel);
            DescriptionPanel.Location = new Point(541, 223);
            DescriptionPanel.Name = "DescriptionPanel";
            DescriptionPanel.Size = new Size(876, 254);
            DescriptionPanel.TabIndex = 2;
            // 
            // guna2Separator4
            // 
            guna2Separator4.Location = new Point(3, 242);
            guna2Separator4.Name = "guna2Separator4";
            guna2Separator4.Size = new Size(870, 12);
            guna2Separator4.TabIndex = 2;
            // 
            // guna2Separator3
            // 
            guna2Separator3.Location = new Point(3, 193);
            guna2Separator3.Name = "guna2Separator3";
            guna2Separator3.Size = new Size(870, 12);
            guna2Separator3.TabIndex = 2;
            // 
            // guna2Separator2
            // 
            guna2Separator2.Location = new Point(3, 147);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new Size(870, 12);
            guna2Separator2.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(3, 101);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(870, 12);
            guna2Separator1.TabIndex = 2;
            // 
            // MovieNameLabel
            // 
            MovieNameLabel.Font = new Font("Segoe UI", 35F);
            MovieNameLabel.ForeColor = SystemColors.Control;
            MovieNameLabel.Location = new Point(3, 14);
            MovieNameLabel.Name = "MovieNameLabel";
            MovieNameLabel.Size = new Size(873, 93);
            MovieNameLabel.TabIndex = 1;
            MovieNameLabel.Text = "Movie Name";
            MovieNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ActorsLabel
            // 
            ActorsLabel.Font = new Font("Segoe UI", 15F);
            ActorsLabel.ForeColor = SystemColors.Control;
            ActorsLabel.Location = new Point(0, 207);
            ActorsLabel.Name = "ActorsLabel";
            ActorsLabel.Size = new Size(873, 46);
            ActorsLabel.TabIndex = 1;
            ActorsLabel.Text = "Actor Label";
            // 
            // YearLabel
            // 
            YearLabel.Font = new Font("Segoe UI", 15F);
            YearLabel.ForeColor = SystemColors.Control;
            YearLabel.Location = new Point(0, 159);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(873, 46);
            YearLabel.TabIndex = 1;
            YearLabel.Text = "Year";
            // 
            // AKALabel
            // 
            AKALabel.Font = new Font("Segoe UI", 15F);
            AKALabel.ForeColor = SystemColors.Control;
            AKALabel.Location = new Point(0, 112);
            AKALabel.Name = "AKALabel";
            AKALabel.Size = new Size(873, 49);
            AKALabel.TabIndex = 1;
            AKALabel.Text = "AKA";
            // 
            // MoviePictureBox
            // 
            MoviePictureBox.BackColor = Color.Transparent;
            MoviePictureBox.CustomizableEdges = customizableEdges5;
            MoviePictureBox.FillColor = Color.Transparent;
            MoviePictureBox.ImageRotate = 0F;
            MoviePictureBox.Location = new Point(74, 223);
            MoviePictureBox.Name = "MoviePictureBox";
            MoviePictureBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            MoviePictureBox.Size = new Size(450, 254);
            MoviePictureBox.TabIndex = 0;
            MoviePictureBox.TabStop = false;
            // 
            // DetailsUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DetailsPanel);
            Name = "DetailsUC";
            Size = new Size(1491, 806);
            Load += DetailsUC_Load;
            DetailsPanel.ResumeLayout(false);
            DescriptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DetailsPanel;
        private Panel DescriptionPanel;
        private Label MovieNameLabel;
        private Label YearLabel;
        private Label AKALabel;
        private Guna.UI2.WinForms.Guna2PictureBox MoviePictureBox;
        private Label ActorsLabel;
        private Guna.UI2.WinForms.Guna2Button AddToListButton;
        private Guna.UI2.WinForms.Guna2Button GoToImdbButton;
        private Label RankLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
    }
}
