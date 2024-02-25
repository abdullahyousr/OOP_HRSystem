using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class Notifier : INotifier
    {
        public Notifier(string smptServer, int port, string SendAddress, string SendPassword)
        {
            SmptServer = smptServer;
            Port = port;
            this.SendAddress = SendAddress;
            this.SendPassword = SendPassword;
        }

        public string SmptServer { get; }
        public int Port { get; }
        public string SendAddress { get; }
        public string SendPassword { get; }

        public void Notify(string email, string subject, string body)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You have an email from {SendAddress} with subject {subject}");
            Console.WriteLine(body);
            Console.WriteLine($"Message send successfully to {email}");
            Console.WriteLine("***************************************");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
