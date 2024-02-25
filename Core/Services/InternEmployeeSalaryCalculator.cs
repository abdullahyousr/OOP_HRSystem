using OOP_HRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class InternEmployeeSalaryCalculator : SalaryCalculator
    {
        public InternEmployeeSalaryCalculator(Employee employee) : base(employee)
        {
        }
        public override decimal Calculate()
        {
            return 2000;
        }
    }
}
