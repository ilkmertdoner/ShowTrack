using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrack
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }
        
        ProductDB ProductDb = new ProductDB();

        private void StockForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDb.GetProductList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(textBoxAddPI.Text), textBoxAddPN.Text, textBoxAddCategory.Text, decimal.Parse(textBoxAddUP.Text),
                int.Parse(textBoxAddQuantity.Text));
            
            
            ProductDb.AddProduct(product);
            dataGridView1.DataSource = ProductDb.GetProductList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(textBoxUpdateID.Text), textBoxUpdatePN.Text, textBoxUpdateCategory.Text, 
                decimal.Parse(textBoxUpdateUP.Text), int.Parse(textBoxUpdateQuantity.Text));

            ProductDb.UpdateProduct(product);
            dataGridView1.DataSource = ProductDb.GetProductList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(textBoxDeleteID.Text), textBoxUpdatePN.Text);

            ProductDb.DeleteProduct(product);
            dataGridView1.DataSource= ProductDb.GetProductList();
        }

        private void StockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
