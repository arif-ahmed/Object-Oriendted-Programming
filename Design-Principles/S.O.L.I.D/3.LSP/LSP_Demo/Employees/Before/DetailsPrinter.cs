namespace LSP_Demo.Employees.Before
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
            foreach (var employee in this.employees)
            {
                if (employee is Manager)
                {
                    this.PrintManager(employee as Manager);
                }
                else
                {
                    this.PrintEmployee(employee);
                }
            }
        }

        private void PrintEmployee(Employee employee)
        {
            string name = employee.Name;

            // print name
            Console.WriteLine(name);

        }

        private void PrintManager(Manager manager)
        {
            string name = manager.Name;
            var documents = manager.Documents;

            // print name and documents
            Console.WriteLine(name);

            foreach (var document in documents)
            {
                Console.WriteLine(document);
            }
        }
    }
}
