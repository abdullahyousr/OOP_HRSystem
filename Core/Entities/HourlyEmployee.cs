﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Entities
{
    internal class HourlyEmployee : DismissableEmployee
    {
        public decimal HourRate { get; set; }
        public int TotalWorkingHours { get; set; }

        //public override IEnumerable<PayItem> GetPayItems()
        //{
        //    return new[] { new PayItem("Total Hours", GetSalary()) };
        //}

        //public override decimal GetSalary()
        //{
        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    return HourRate * TotalWorkingHours;
        //}
    }
}
