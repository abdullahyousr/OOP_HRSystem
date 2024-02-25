using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_HRSystem.Core.Entities;

namespace OOP_HRSystem.Core.Services
{
    internal class PayslipGenerator
    {
        public PayslipGenerator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public INotifier _notifier { get; }

        //public void Generate(Employee employee)
        //{
        //    //var payItems = employee.GetPayItems();
        //    var message = new StringBuilder();
        //    message.AppendLine($"Dear {employee.FirstName} {employee.LastName},");
        //    message.AppendLine($"Please find your payslip details:");
        //    foreach (var payitem in payItems)
        //    {
        //        message.AppendLine($"{payitem.Name} \t\t {payitem.Value}");
        //    }
        //    _notifier.Notify(employee.Email, "Payslip Generator", message.ToString());
        //}
    }
}
