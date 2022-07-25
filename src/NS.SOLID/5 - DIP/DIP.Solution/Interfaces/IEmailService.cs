namespace NS.SOLID.DIP.Solution.Interfaces
{
    public interface IEmailService
    {
        bool IsValid(string email);
        void Send(string from, string to, string subject, string body);
    }
}
