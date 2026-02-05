namespace ShowTrack
{
    partial class SearchUC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ResultPanel = new FlowLayoutPanel();
            SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(ResultPanel);
            guna2Panel1.Controls.Add(SearchTextBox);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(guna2Separator1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.FromArgb(35, 35, 35);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1491, 804);
            guna2Panel1.TabIndex = 1;
            // 
            // ResultPanel
            // 
            ResultPanel.AutoScroll = true;
            ResultPanel.BackColor = Color.FromArgb(40, 40, 40);
            ResultPanel.FlowDirection = FlowDirection.TopDown;
            ResultPanel.Location = new Point(45, 182);
            ResultPanel.Name = "ResultPanel";
            ResultPanel.Size = new Size(1402, 606);
            ResultPanel.TabIndex = 4;
            ResultPanel.WrapContents = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.AutoRoundedCorners = true;
            SearchTextBox.BackColor = Color.Transparent;
            SearchTextBox.BorderColor = Color.FromArgb(50, 50, 50);
            SearchTextBox.CustomizableEdges = customizableEdges1;
            SearchTextBox.DefaultText = "";
            SearchTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchTextBox.FillColor = Color.FromArgb(50, 50, 50);
            SearchTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.Font = new Font("Segoe UI", 10F);
            SearchTextBox.ForeColor = Color.White;
            SearchTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchTextBox.IconRight = Properties.Resources.search_interface_symbol;
            SearchTextBox.IconRightOffset = new Point(15, -2);
            SearchTextBox.IconRightSize = new Size(35, 35);
            SearchTextBox.Location = new Point(341, 25);
            SearchTextBox.Margin = new Padding(4, 5, 4, 5);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderForeColor = Color.White;
            SearchTextBox.PlaceholderText = "Search Movie/Series";
            SearchTextBox.SelectedText = "";
            SearchTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchTextBox.Size = new Size(809, 69);
            SearchTextBox.TabIndex = 3;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.AutoSize = false;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonHighlight;
            guna2HtmlLabel1.Location = new Point(45, 112);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(139, 46);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Result";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            guna2Separator1.BackColor = Color.Transparent;
            guna2Separator1.Location = new Point(45, 164);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1402, 12);
            guna2Separator1.TabIndex = 1;
            // 
            // SearchUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "SearchUC";
            Size = new Size(1491, 804);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private FlowLayoutPanel ResultPanel;
    }
}
