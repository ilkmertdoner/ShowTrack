using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTrack
{
    public class ProductDB
    {
        private static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\StockTrack.mdf;Integrated Security=True";
        SqlConnection Connection = new SqlConnection(connStr);

        public DataTable GetProductList()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM ProductInventory", Connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            Connection.Close();

            return dataTable;
        }

        public void AddProduct(Product product)
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand command = new SqlCommand("INSERT INTO ProductInventory (ProductName, Category, Quantity, UnitPrice) VALUES " +
                    "(@ProductName, @Category, @Quantity, @Price)", Connection);

            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Category", product.Category);
            command.Parameters.AddWithValue("@Quantity", product.Quantity);
            command.Parameters.AddWithValue("@Price", product.UnitPrice);
            command.ExecuteNonQuery();

            Connection.Close();
        }

        public void UpdateProduct(Product product)
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            SqlCommand command = new SqlCommand("UPDATE ProductInventory SET ProductName = @ProductName, Category = @Category, " +
                "Quantity = @Quantity, UnitPrice = @Price WHERE Id = @Id", Connection);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Category", product.Category);
            command.Parameters.AddWithValue("@Quantity", product.Quantity);
            command.Parameters.AddWithValue("@Price", product.UnitPrice);
            command.Parameters.AddWithValue("@Id", product.ProductID);

            command.ExecuteNonQuery();
            Connection.Close();
        }

        public void DeleteProduct(Product product)
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            
            SqlCommand command = new SqlCommand("DELETE FROM ProductInventory WHERE Id = @Id", Connection);
            command.Parameters.AddWithValue("@Id", product.ProductID);
            command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
