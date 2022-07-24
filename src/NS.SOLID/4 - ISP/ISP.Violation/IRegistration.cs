namespace NS.SOLID.ISP.Violation
{
    public interface IRegistration
    {
        void Validate();
        void SaveToDatabase();
        void SendEmail();
    }
}
