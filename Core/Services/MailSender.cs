using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class MailSender : IMailSender
    {
        private readonly ILogger _logger;

        public MailSender(ILogger logger)
        {
            _logger = logger;
        }


        public void Send(string to, string subject, string body)
        {
            _logger.LogMessage($"Sending Email to {to}");
        }
    }
}
