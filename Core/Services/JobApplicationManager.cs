using OOP_HRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class JobApplicationManager : IJobApplicationManager
    {
        private readonly ILogger _logger ;
        private readonly IMailSender _mailSender;

        public JobApplicationManager(ILogger logger, IMailSender mailSender)
        {
            _logger = logger;
            _mailSender = mailSender;
        }
        public void AddApplication(Applicant applicant, int vacancyId)
        {
            Console.WriteLine($"New applicant applied for job vacancy #{vacancyId}");
            SendApplicationConsfirmationMail(applicant, vacancyId);

            _logger.LogMessage($"Application recieved for job vacancy #{vacancyId}");
        }

        private void SendApplicationConsfirmationMail(Applicant applicant, int vacancyId)
        {
            _mailSender.Send("application@example.com", "Job application confirmation", "job application received");
            Console.WriteLine($"Application confirmation mail sent to applicant {applicant.FirstName} {applicant.LastName}");
        }
        public void RemoveApplication(Applicant applicant, int vacancyId)
        {
            Console.WriteLine($"Application removed from vacancy #{vacancyId}");
            SendApplicationRemovalMail(applicant, vacancyId);
        }

        private void SendApplicationRemovalMail(Applicant applicant, int vacancyId)
        {
            var mailSender = new MailSender();
            mailSender.Send("application@example.com", "Job application removal confirmation", "job application removed");
            Console.WriteLine($"Application removal confirmation mail sent to applicant {applicant.FirstName} {applicant.LastName}");
        }

    }
}
