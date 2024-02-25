using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Entities
{
    internal class SalariedEmployee : DismissableEmployee
    {
        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }
        //public override IEnumerable<PayItem> GetPayItems()
        //{
        //    return new[]
        //    {
        //        new PayItem("BasicSalary", BasicSalary),
        //        new PayItem("Transportation", Transportation),
        //        new PayItem("Housing", Housing),
        //    };
        //}
        //public override decimal GetSalary()
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    return BasicSalary + Transportation + Housing;
        //}
        //public decimal GetSalary(int taxPercentage)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    return GetSalary() - BasicSalary * taxPercentage / 100;
        //}
        //public decimal GetSalary(int taxPercentage, int bonus)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    return GetSalary(taxPercentage) + bonus;
        //}
    }
}
