namespace ShowTrack
{
    partial class MyListUC
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
            MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            label1 = new Label();
            ResultPanel = new FlowLayoutPanel();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(guna2Separator1);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(ResultPanel);
            MainPanel.CustomizableEdges = customizableEdges1;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.FillColor = Color.FromArgb(35, 35, 35);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            MainPanel.Size = new Size(1491, 804);
            MainPanel.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            guna2Separator1.BackColor = Color.Transparent;
            guna2Separator1.Location = new Point(44, 77);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1402, 12);
            guna2Separator1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(654, 17);
            label1.Name = "label1";
            label1.Size = new Size(182, 57);
            label1.TabIndex = 1;
            label1.Text = "Your List";
            // 
            // ResultPanel
            // 
            ResultPanel.AutoScroll = true;
            ResultPanel.BackColor = Color.FromArgb(45, 45, 45);
            ResultPanel.FlowDirection = FlowDirection.TopDown;
            ResultPanel.Location = new Point(44, 93);
            ResultPanel.Name = "ResultPanel";
            ResultPanel.Size = new Size(1402, 692);
            ResultPanel.TabIndex = 0;
            ResultPanel.WrapContents = false;
            // 
            // MyListUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Name = "MyListUC";
            Size = new Size(1491, 804);
            Load += MyListUC_Load;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private FlowLayoutPanel ResultPanel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
