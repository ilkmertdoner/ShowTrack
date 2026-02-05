namespace ShowTrack
{
    partial class MainFormUC
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label1 = new Label();
            SeriesPanel = new FlowLayoutPanel();
            MoviePanel = new FlowLayoutPanel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(SeriesPanel);
            guna2Panel1.Controls.Add(MoviePanel);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(35, 35, 35);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1491, 804);
            guna2Panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(16, 424);
            label2.Name = "label2";
            label2.Size = new Size(205, 41);
            label2.TabIndex = 2;
            label2.Text = "Popular Series";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 80);
            label1.Name = "label1";
            label1.Size = new Size(222, 41);
            label1.TabIndex = 2;
            label1.Text = "Popular Movies\r\n";
            // 
            // SeriesPanel
            // 
            SeriesPanel.BackColor = Color.FromArgb(45, 45, 45);
            SeriesPanel.Location = new Point(16, 472);
            SeriesPanel.Name = "SeriesPanel";
            SeriesPanel.Padding = new Padding(25, 2, 0, 0);
            SeriesPanel.Size = new Size(1462, 253);
            SeriesPanel.TabIndex = 0;
            // 
            // MoviePanel
            // 
            MoviePanel.BackColor = Color.FromArgb(45, 45, 45);
            MoviePanel.Location = new Point(16, 128);
            MoviePanel.Name = "MoviePanel";
            MoviePanel.Padding = new Padding(25, 2, 0, 0);
            MoviePanel.Size = new Size(1462, 253);
            MoviePanel.TabIndex = 0;
            // 
            // MainFormUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "MainFormUC";
            Size = new Size(1491, 804);
            Load += MainFormUC_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel MoviePanel;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel SeriesPanel;
    }
}
