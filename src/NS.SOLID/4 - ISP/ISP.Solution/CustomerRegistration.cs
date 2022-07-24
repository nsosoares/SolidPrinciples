namespace NS.SOLID.ISP.Solution
{
    public class CustomerRegistration : ICustomerRegistration
    {
        public void Validate()
        {
            //Validate data before saving
        }

        public void SaveToDatabase()
        {
            //Insert customer into database
        }

        public void SendEmail()
        {
            //Send email after registering customer
        }
    }
}
