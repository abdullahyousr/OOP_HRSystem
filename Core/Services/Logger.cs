using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class Logger : ILogger
    {
        public void LogMessage(string message)
        {
            using (var stream = new StreamWriter("log.txt", true))
            {
                stream.WriteLine(message);
            }
        }
    }
}
