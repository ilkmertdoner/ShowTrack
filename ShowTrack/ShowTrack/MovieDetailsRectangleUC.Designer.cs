namespace ShowTrack
{
    partial class MovieDetailsRectangleUC
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
            MoviePictureBox = new PictureBox();
            MovieNameLabel = new Label();
            ReleaseDateLabel = new Label();
            DetailsButton = new Guna.UI2.WinForms.Guna2Button();
            AddToListButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).BeginInit();
            SuspendLayout();
            // 
            // MoviePictureBox
            // 
            MoviePictureBox.Location = new Point(3, 3);
            MoviePictureBox.Name = "MoviePictureBox";
            MoviePictureBox.Size = new Size(191, 101);
            MoviePictureBox.TabIndex = 0;
            MoviePictureBox.TabStop = false;
            // 
            // MovieNameLabel
            // 
            MovieNameLabel.AutoEllipsis = true;
            MovieNameLabel.Font = new Font("Segoe UI", 15F);
            MovieNameLabel.ForeColor = SystemColors.Control;
            MovieNameLabel.Location = new Point(200, 14);
            MovieNameLabel.Name = "MovieNameLabel";
            MovieNameLabel.Size = new Size(727, 39);
            MovieNameLabel.TabIndex = 1;
            MovieNameLabel.Text = "Dexter";
            // 
            // ReleaseDateLabel
            // 
            ReleaseDateLabel.AutoSize = true;
            ReleaseDateLabel.Font = new Font("Segoe UI", 10F);
            ReleaseDateLabel.ForeColor = SystemColors.Control;
            ReleaseDateLabel.Location = new Point(200, 65);
            ReleaseDateLabel.Name = "ReleaseDateLabel";
            ReleaseDateLabel.Size = new Size(117, 23);
            ReleaseDateLabel.TabIndex = 1;
            ReleaseDateLabel.Text = "Release Date: ";
            // 
            // DetailsButton
            // 
            DetailsButton.AutoRoundedCorners = true;
            DetailsButton.CustomizableEdges = customizableEdges1;
            DetailsButton.DisabledState.BorderColor = Color.DarkGray;
            DetailsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            DetailsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DetailsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DetailsButton.FillColor = Color.FromArgb(70, 70, 70);
            DetailsButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            DetailsButton.ForeColor = Color.White;
            DetailsButton.Location = new Point(964, 23);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DetailsButton.Size = new Size(194, 56);
            DetailsButton.TabIndex = 2;
            DetailsButton.Text = "Details";
            DetailsButton.Click += DetailsButton_Click;
            // 
            // AddToListButton
            // 
            AddToListButton.AutoRoundedCorners = true;
            AddToListButton.CustomizableEdges = customizableEdges3;
            AddToListButton.DisabledState.BorderColor = Color.DarkGray;
            AddToListButton.DisabledState.CustomBorderColor = Color.DarkGray;
            AddToListButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddToListButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddToListButton.FillColor = Color.FromArgb(70, 70, 70);
            AddToListButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            AddToListButton.ForeColor = Color.White;
            AddToListButton.Location = new Point(1164, 23);
            AddToListButton.Name = "AddToListButton";
            AddToListButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            AddToListButton.Size = new Size(194, 56);
            AddToListButton.TabIndex = 2;
            AddToListButton.Text = "Add To List";
            AddToListButton.Click += AddToListButton_Click;
            // 
            // MovieDetailsRectangleUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            Controls.Add(AddToListButton);
            Controls.Add(DetailsButton);
            Controls.Add(ReleaseDateLabel);
            Controls.Add(MovieNameLabel);
            Controls.Add(MoviePictureBox);
            Name = "MovieDetailsRectangleUC";
            Size = new Size(1370, 107);
            ((System.ComponentModel.ISupportInitialize)MoviePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MoviePictureBox;
        private Label MovieNameLabel;
        private Label ReleaseDateLabel;
        private Guna.UI2.WinForms.Guna2Button DetailsButton;
        private Guna.UI2.WinForms.Guna2Button AddToListButton;
    }
}
