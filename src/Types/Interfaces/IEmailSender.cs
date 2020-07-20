namespace Types.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(string receiver, string title, string message);
    }
}