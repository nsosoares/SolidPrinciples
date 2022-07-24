namespace NS.SOLID.ISP.Violation
{
    public class ProductRegistration : IRegistration
    {
        /*
         With the implementation of a single interface, the product 
         class ends up having a method that it doesn't need to have.
         */

        public void Validate()
        {
            //Validate data before saving
        }

        public void SaveToDatabase()
        {
            //Insert product into database
        }

        public void SendEmail()
        {
            //Product does not have email, method is therefore useless
        }
    }
}
