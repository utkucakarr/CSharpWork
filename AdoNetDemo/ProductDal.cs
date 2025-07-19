using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Ecommerce;integrated security=true");
        public List<Product> GetAll()
        {
            //Uzaktaki veri tabanına bağlanmak için
            //SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Ecommerce;integrated security=true; uid=utku;password=1234");
            //initial catalog hangi veri tabanına bağlanıcağımızı belirtir.
            ConnectionControl();
            //Sorgumuzu yazdık.
            SqlCommand command = new SqlCommand("Select * From Products", _sqlConnection);

            //Komutu çalıştırdık.
            SqlDataReader sqlDataReader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = Convert.ToString(sqlDataReader["Name"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"])
                };
                products.Add(product);
            }

            sqlDataReader.Close();
            _sqlConnection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }

        public DataTable GetAll2()
        {
            //Uzaktaki veri tabanına bağlanmak için
            //SqlConnection sqlConnection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Ecommerce;integrated security=true; uid=utku;password=1234");
            //initial catalog hangi veri tabanına bağlanıcağımızı belirtir.
            ConnectionControl();
            //Sorgumuzu yazdık.
            SqlCommand command = new SqlCommand("Select * From Products", _sqlConnection);

            //Komutu çalıştırdık.
            SqlDataReader sqlDataReader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            sqlDataReader.Close();
            _sqlConnection.Close();
            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "INSERT INTO Products Values(@name, @UnirPrice, @StockAmount)", _sqlConnection);

            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@UnirPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "UPDATE Products SET Name = @name, UnitPrice = @unitPrice, StockAmount = @stockAmount WHERE Id = @id", _sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", product.Id);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Remove(int id)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand(
                "DELETE FROM Products Where Id = @id", _sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }
    }
}
