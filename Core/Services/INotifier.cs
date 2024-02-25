using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_HRSystem.Core.Services
{
    internal interface INotifier
    {
        void Notify(string email, string subject, string body);
    }
}
