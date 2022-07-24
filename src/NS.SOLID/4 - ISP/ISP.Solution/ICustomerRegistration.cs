namespace NS.SOLID.ISP.Solution
{
    public interface ICustomerRegistration
    {
        void Validate();
        void SaveToDatabase();
        void SendEmail();
    }
}
