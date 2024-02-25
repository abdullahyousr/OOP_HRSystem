using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Entities
{
    public abstract class Employee : Person
    {
        public string Email { get; internal set; }
     
    }
}
