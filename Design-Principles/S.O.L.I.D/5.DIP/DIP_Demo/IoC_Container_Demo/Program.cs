using IoC_Container_Demo.Refactored;
using System.Text;

namespace IoC_Container_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunV1();
            RunRefactored_v1();
            RunRefactored_v2();
            Console.ReadKey();
        }

        static void RunV1()
        {
            // Uncomment the following lines to run the v1 code
            var customerLogic = new v1.CustomerBusinessLogic();
            Console.WriteLine(customerLogic.ProcessCustomerData(1));
        }

        static void RunRefactored_v1()
        {
            // POOR MAN'S DI
            var customerLogic = new Refactored.CustomerBusinessLogic(new Refactored.CustomerDataAccess());
            Console.WriteLine(customerLogic.ProcessCustomerData(1));
        }

        static void RunRefactored_v2()
        {
            // Uncomment the following lines to run the refactored v2 code
            // var customerLogic = new Refactored.CustomerBusinessLogic(new Refactored.CustomerDataAccess());
            // Console.WriteLine(customerLogic.ProcessCustomerData(1));

            var resolver = new Resolver();
            resolver.Registery<Refactored.Contracts.IDataAccess, Refactored.CustomerDataAccess>();
            resolver.Registery<Refactored.CustomerBusinessLogic>();

            var customerLogic = resolver.Resolve<Refactored.CustomerBusinessLogic>();
            Console.WriteLine(customerLogic.ProcessCustomerData(1));
        }
    }
}
