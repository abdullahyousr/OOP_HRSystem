using OOP_HRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal class HourlyEmployeeSalaryCalculator : SalaryCalculator
    {
        public HourlyEmployeeSalaryCalculator(Employee employee) : base(employee)
        {
        }
        public override decimal Calculate()
        {
                var hourlyEmployee = Employee as HourlyEmployee;
                return hourlyEmployee.HourRate + hourlyEmployee.TotalWorkingHours;
        }
    }
}
