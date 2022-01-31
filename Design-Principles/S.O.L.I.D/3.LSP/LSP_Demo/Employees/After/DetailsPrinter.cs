namespace LSP_Demo.Employees.After
{
    using System;
    using System.Collections.Generic;

    public class DetailsPrinter
    {
        private readonly IEnumerable<Employee> employees;

        public DetailsPrinter(IEnumerable<Employee> employees)
        {
            this.employees = employees;
        }

        public void Print()
        {
            foreach (var employee in employees)
            {
                employee.Print();
            }
        }
    }
}
