namespace Details_Printer
{
    using System.Collections.Generic;

    public class DetailsPrinterDemo
    {
        public static void LSP_Violated_Code()
        {
            IList<LSP_Violated.Employee> employees = new List<LSP_Violated.Employee>
            {
                new LSP_Violated.Employee("Employee"),
                new LSP_Violated.Manager("Manager", new List<string> { "Doc 1", "Doc 2", "Doc 3" })
            };

            LSP_Violated.DetailsPrinter detailsPrinter = new LSP_Violated.DetailsPrinter(employees);
            detailsPrinter.PrintDetails();
        }

        public static void LSP_Non_Violated_Code()
        {
            IList<LSP_Non_Violated.Employee> employees = new List<LSP_Non_Violated.Employee>
            {
                new LSP_Non_Violated.Employee("Employee"),
                new LSP_Non_Violated.Manager("Manager", new List<string> { "Doc 1", "Doc 2", "Doc 3" })
            };

            LSP_Non_Violated.DetailsPrinter detailsPrinter = new LSP_Non_Violated.DetailsPrinter(employees);
            detailsPrinter.PrintDetails();
        }
    }
}
