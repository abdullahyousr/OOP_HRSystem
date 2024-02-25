using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class Factory
    {
        public static IJobApplicationManager Create()
        {
            var logger = CreateLogger();
            var mailSender = CreateMailSender(logger);
            return new JobApplicationManager(logger,mailSender);
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
        public static IMailSender CreateMailSender(ILogger logger)
        {
            return new MailSender(logger);
        }
    }
}
