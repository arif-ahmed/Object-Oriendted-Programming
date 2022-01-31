namespace Details_Printer.LSP_Non_Violated      
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
                employee.Print();
            }
        }
    }
}
