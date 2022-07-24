namespace NS.SOLID.ISP.Violation
{
    public class CustomerRegistration : IRegistration
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
