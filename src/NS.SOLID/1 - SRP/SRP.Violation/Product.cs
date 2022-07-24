using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace NS.SOLID.SRP.Violation
{
    public class Product
    {
        /*
         This class violates the SRP due to having 
         multiple reasons to change it
        */

        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Name { get; set; }
        public string CustomerEmail { get; set; }
        public decimal Price { get; set; }

        public string AddProduct()
        {
            //1 - VALIDATION RESPONSIBILITY

            if (Name.Trim().Length > 0)
                return "Product needs a name";

            if (!CustomerEmail.Contains("@"))
                return "Customer email is invalid";

            if(Price < 1)
                return "Price must be greater than zero";

            if(Price > 1000)
                return "Price must be less than thousand";

            //2 - RESPONSIBILITY FOR CONNECTION AND INSERTION IN THE DATABASE
            using (var connection = new SqlConnection())
            {
                var cmd = new SqlCommand();

                connection.ConnectionString = "DefaultConnection";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PRODUCT (REGISTRATIONDATE, NAME, CUSTOMEREMAIL) VALUES (@registrationDate, @name, @customerEmail)";

                cmd.Parameters.AddWithValue("registrationDate", RegistrationDate);
                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("customerEmail", CustomerEmail);

                connection.Open();
                cmd.ExecuteNonQuery();
            }

            //3 - RESPONSIBILITY FOR SENDING EMAIL TO THE CUSTOMER
            var mail = new MailMessage("nsosoares@nsosoares.com", CustomerEmail);
            var client = new SmtpClient 
            { 
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com",
            };

            mail.Subject = "Product purchased";
            mail.Body = "Congratulations! The product was successfully purchased";
            client.Send(mail);

            return "Product successfully purchased";
        }
    }
}
