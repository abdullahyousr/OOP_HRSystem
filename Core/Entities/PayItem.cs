using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Entities
{
    internal class PayItem
    {
        public string Name { get; }
        public decimal Value { get; }

        public PayItem(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

    }
}
