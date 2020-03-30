﻿namespace Details_Printer.LSP_Violated
{
    using System;
    using System.Collections.Generic;
    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (Employee employee in employees)
            {
                if (employee is Manager)
                {
                    PrintManager((Manager)employee);
                }
                else
                {
                    PrintEmployee(employee);
                }
            }
        }

        private void PrintEmployee(Employee employee)
        {
            Console.WriteLine(employee.Name);
        }

        private void PrintManager(Manager manager)
        {
            Console.WriteLine(manager.Name);
            Console.WriteLine(string.Join(Environment.NewLine, manager.Documents));
        }
    }
}
