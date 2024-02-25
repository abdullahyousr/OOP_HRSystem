using OOP_HRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class SalariedEmployeeSalaryCalculator : SalaryCalculator
    {
        public SalariedEmployeeSalaryCalculator(Employee employee) : base(employee)
        {
        }
        public override decimal Calculate()
        {
            var salariedEmployee = Employee as SalariedEmployee;
            return salariedEmployee.BasicSalary + salariedEmployee.Transportation + salariedEmployee.Housing;
        }
    }
}
