﻿using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo.EmployeeAdministration.VisitorModels;

namespace VisitorPatternDemo.EmployeeAdministration.ElementModels
{
    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    public class Employee : Element
    {
        public Employee(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        public string Name { get; set; }
        public double Income { get; set; }
        public int VacationDays { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
