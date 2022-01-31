namespace LSP_Demo.Employees
{
    using System.Collections.Generic;
    public class Employees
    {
        public static void Before_Demo()
        {
            List<Before.Employee> employees = new List<Before.Employee> 
            {
                new Before.Employee { Name = "Employee" },
                new Before.Manager { Name = "Manager", Documents = new List<string> { "Doc 1", "Doc 2", "Doc 3" } }
            }; 

            Before.DetailsPrinter detailsPrinter = new Before.DetailsPrinter(employees);
            detailsPrinter.Print();
        }

        public static void After_Demo()
        {
            List<After.Employee> employees = new List<After.Employee>
            {
                new After.Employee { Name = "Employee" },
                new After.Manager { Name = "Manager", Documents = new List<string> { "Doc 1", "Doc 2", "Doc 3" } }
            };

            After.DetailsPrinter detailsPrinter = new After.DetailsPrinter(employees);
            detailsPrinter.Print();
        }
    }
}
