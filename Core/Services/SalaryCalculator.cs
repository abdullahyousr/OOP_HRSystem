﻿using OOP_HRSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HRSystem.Core.Services
{
    internal abstract class SalaryCalculator
    {
        public SalaryCalculator(Employee employee)
        {
            Employee = employee;
        }

        public Employee Employee { get; }
        public abstract decimal Calculate();
    }
}
