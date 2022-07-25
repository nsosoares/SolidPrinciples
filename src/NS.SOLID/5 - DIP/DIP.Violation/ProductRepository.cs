using System.Data;
using System.Data.SqlClient;

namespace NS.SOLID.DIP.Violation
{
    public class ProductRepository
    {
        public void AddProduct(Product product)
        {
            using (var connection = new SqlConnection())
            {
                var cmd = new SqlCommand();

                connection.ConnectionString = "DefaultConnection";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PRODUCT (REGISTRATIONDATE, NAME, CUSTOMEREMAIL) VALUES (@registrationDate, @name, @customerEmail)";

                cmd.Parameters.AddWithValue("registrationDate", product.RegistrationDate);
                cmd.Parameters.AddWithValue("name", product.Name);
                cmd.Parameters.AddWithValue("customerEmail", product.CustomerEmail);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
