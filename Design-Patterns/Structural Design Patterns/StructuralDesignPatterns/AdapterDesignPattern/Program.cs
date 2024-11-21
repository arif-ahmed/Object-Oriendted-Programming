using AdapterDesignPattern.Example_02;
using AdapterDesignPattern.Structural;

namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Structure();
            Example_02();
            Console.ReadKey();
        }

        static void Structure()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
        }

        static void Example_02()
        {
            //Storing the Employees Data in a String Array
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };
            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
        }
    }
}
