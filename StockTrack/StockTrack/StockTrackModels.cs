using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrack
{
    public class Product
    {
        public int ProductID { get; private set; }
        public string ProductName { get; private set; }
        public string Category { get; private set; }
        public decimal? UnitPrice { get; private set; }
        public int? Quantity { get; private set; }

        public Product(int _ProductID, string _ProductName, string _Category, decimal _UnitPrice, int _Quantity)
        {
            if(_ProductID < 0) MessageBox.Show("Product ID cannot be negative.");
            if(string.IsNullOrWhiteSpace(_ProductName)) MessageBox.Show("Product Name cannot be empty.");
            if(string.IsNullOrWhiteSpace(_Category)) MessageBox.Show("Category cannot be empty.");
            if(_UnitPrice < 0) MessageBox.Show("Unit Price cannot be negative.");

            ProductID = _ProductID;
            ProductName = _ProductName;
            Category = _Category;
            UnitPrice = _UnitPrice;
            Quantity = _Quantity;
        }

        public Product(int _ProductID, string _ProductName)
        {
            if (_ProductID < 0) MessageBox.Show("Product ID cannot be negative.");
            if (string.IsNullOrWhiteSpace(_ProductName)) MessageBox.Show("Product Name cannot be empty.");

            ProductID = _ProductID;
            ProductName = _ProductName;
        }
    }
}
