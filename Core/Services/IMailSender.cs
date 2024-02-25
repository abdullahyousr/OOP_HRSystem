namespace OOP_HRSystem.Core.Services
{
    internal interface IMailSender
    {
        void Send(string to, string subject, string body);
    }
}