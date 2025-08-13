namespace StockTrack
{
    partial class StockForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAddPN = new System.Windows.Forms.TextBox();
            this.textBoxAddCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAddQuantity = new System.Windows.Forms.TextBox();
            this.textBoxAddUP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdatePN = new System.Windows.Forms.TextBox();
            this.textBoxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.textBoxUpdateCategory = new System.Windows.Forms.TextBox();
            this.textBoxUpdateUP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDeletePN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.textBoxUpdateID = new System.Windows.Forms.TextBox();
            this.labelUpdateID = new System.Windows.Forms.Label();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.textBoxDeleteID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAddPI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(79, 203);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 36);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAddPN
            // 
            this.textBoxAddPN.Location = new System.Drawing.Point(120, 55);
            this.textBoxAddPN.Name = "textBoxAddPN";
            this.textBoxAddPN.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddPN.TabIndex = 2;
            // 
            // textBoxAddCategory
            // 
            this.textBoxAddCategory.Location = new System.Drawing.Point(121, 91);
            this.textBoxAddCategory.Name = "textBoxAddCategory";
            this.textBoxAddCategory.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddCategory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // textBoxAddQuantity
            // 
            this.textBoxAddQuantity.Location = new System.Drawing.Point(121, 130);
            this.textBoxAddQuantity.Name = "textBoxAddQuantity";
            this.textBoxAddQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddQuantity.TabIndex = 4;
            // 
            // textBoxAddUP
            // 
            this.textBoxAddUP.Location = new System.Drawing.Point(120, 166);
            this.textBoxAddUP.Name = "textBoxAddUP";
            this.textBoxAddUP.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddUP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(87, 203);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 36);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdatePN
            // 
            this.textBoxUpdatePN.Location = new System.Drawing.Point(124, 53);
            this.textBoxUpdatePN.Name = "textBoxUpdatePN";
            this.textBoxUpdatePN.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdatePN.TabIndex = 8;
            // 
            // textBoxUpdateQuantity
            // 
            this.textBoxUpdateQuantity.Location = new System.Drawing.Point(124, 128);
            this.textBoxUpdateQuantity.Name = "textBoxUpdateQuantity";
            this.textBoxUpdateQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateQuantity.TabIndex = 10;
            // 
            // textBoxUpdateCategory
            // 
            this.textBoxUpdateCategory.Location = new System.Drawing.Point(124, 89);
            this.textBoxUpdateCategory.Name = "textBoxUpdateCategory";
            this.textBoxUpdateCategory.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateCategory.TabIndex = 9;
            // 
            // textBoxUpdateUP
            // 
            this.textBoxUpdateUP.Location = new System.Drawing.Point(124, 164);
            this.textBoxUpdateUP.Name = "textBoxUpdateUP";
            this.textBoxUpdateUP.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateUP.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Unit Price";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(83, 192);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 36);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDeletePN
            // 
            this.textBoxDeletePN.Location = new System.Drawing.Point(126, 100);
            this.textBoxDeletePN.Name = "textBoxDeletePN";
            this.textBoxDeletePN.Size = new System.Drawing.Size(100, 22);
            this.textBoxDeletePN.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Product Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Category";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxAddPI);
            this.groupBoxAdd.Controls.Add(this.textBoxAddPN);
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.textBoxAddQuantity);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.textBoxAddCategory);
            this.groupBoxAdd.Controls.Add(this.textBoxAddUP);
            this.groupBoxAdd.Controls.Add(this.label10);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Location = new System.Drawing.Point(25, 330);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(257, 246);
            this.groupBoxAdd.TabIndex = 4;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add Product";
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateID);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdatePN);
            this.groupBoxUpdate.Controls.Add(this.buttonUpdate);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateQuantity);
            this.groupBoxUpdate.Controls.Add(this.label8);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateCategory);
            this.groupBoxUpdate.Controls.Add(this.textBoxUpdateUP);
            this.groupBoxUpdate.Controls.Add(this.labelUpdateID);
            this.groupBoxUpdate.Controls.Add(this.label7);
            this.groupBoxUpdate.Controls.Add(this.label5);
            this.groupBoxUpdate.Controls.Add(this.label6);
            this.groupBoxUpdate.Location = new System.Drawing.Point(298, 330);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(257, 246);
            this.groupBoxUpdate.TabIndex = 5;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "Update Product";
            // 
            // textBoxUpdateID
            // 
            this.textBoxUpdateID.Location = new System.Drawing.Point(124, 21);
            this.textBoxUpdateID.Name = "textBoxUpdateID";
            this.textBoxUpdateID.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdateID.TabIndex = 7;
            // 
            // labelUpdateID
            // 
            this.labelUpdateID.AutoSize = true;
            this.labelUpdateID.Location = new System.Drawing.Point(50, 27);
            this.labelUpdateID.Name = "labelUpdateID";
            this.labelUpdateID.Size = new System.Drawing.Size(67, 16);
            this.labelUpdateID.TabIndex = 3;
            this.labelUpdateID.Text = "Product Id";
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.textBoxDeleteID);
            this.groupBoxDelete.Controls.Add(this.textBoxDeletePN);
            this.groupBoxDelete.Controls.Add(this.label9);
            this.groupBoxDelete.Controls.Add(this.buttonDelete);
            this.groupBoxDelete.Controls.Add(this.label13);
            this.groupBoxDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDelete.Location = new System.Drawing.Point(572, 330);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(257, 246);
            this.groupBoxDelete.TabIndex = 6;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Delete Product";
            // 
            // textBoxDeleteID
            // 
            this.textBoxDeleteID.Location = new System.Drawing.Point(126, 72);
            this.textBoxDeleteID.Name = "textBoxDeleteID";
            this.textBoxDeleteID.Size = new System.Drawing.Size(100, 22);
            this.textBoxDeleteID.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Product Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Product Id";
            // 
            // textBoxAddPI
            // 
            this.textBoxAddPI.Location = new System.Drawing.Point(120, 21);
            this.textBoxAddPI.Name = "textBoxAddPI";
            this.textBoxAddPI.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddPI.TabIndex = 1;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 588);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StockForm";
            this.Text = "Stock Tracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockForm_FormClosed);
            this.Load += new System.EventHandler(this.StockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAddPN;
        private System.Windows.Forms.TextBox textBoxAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAddQuantity;
        private System.Windows.Forms.TextBox textBoxAddUP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdatePN;
        private System.Windows.Forms.TextBox textBoxUpdateQuantity;
        private System.Windows.Forms.TextBox textBoxUpdateCategory;
        private System.Windows.Forms.TextBox textBoxUpdateUP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDeletePN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.TextBox textBoxUpdateID;
        private System.Windows.Forms.Label labelUpdateID;
        private System.Windows.Forms.TextBox textBoxDeleteID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddPI;
        private System.Windows.Forms.Label label10;
    }
}