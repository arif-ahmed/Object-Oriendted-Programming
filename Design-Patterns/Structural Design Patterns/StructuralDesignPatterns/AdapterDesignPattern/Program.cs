using AdapterDesignPattern.Example_01;
using AdapterDesignPattern.Example_02;
using AdapterDesignPattern.Example_04;
using AdapterDesignPattern.Structural;
using Example_03;

namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Structure();
            // Example_01();
            // Example_01();
            // Example_02();
            // Example_02();
            // Example_04();
            // Example_05();
            Console.ReadKey();
        }

        static void Structure()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
        }


        static void Example_01() 
        {
            StockMarketXmlProvider stockMarketXmlProvider = new StockMarketXmlProvider();
            IJsonDataProvider jsonDataProvider = new XmlToJsonAdapter(stockMarketXmlProvider);
            jsonDataProvider.GetJsonData();
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

        static void Example_03() 
        {
            ICompound water = new RichCompound("Water");
            water.Display();

            ICompound benzene = new RichCompound("Benzene");
            benzene.Display();

            ICompound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }

        static void Example_04() 
        {
            /** 
            // Setting up Dependency Injection
            var serviceProvider = new ServiceCollection()
                .AddScoped<IPayPalPayment, PayPalPayment>()
                .AddScoped<IStripePayment, StripePayment>()
                .AddScoped<IPaymentAdapter>("PayPalAdapter", serviceProvider => 
                    new PayPalAdapter(serviceProvider.GetRequiredService<IPayPalPayment>()))
                .AddScoped<IPaymentAdapter>("StripeAdapter", serviceProvider => 
                    new StripeAdapter(serviceProvider.GetRequiredService<IStripePayment>()))
                .BuildServiceProvider();

            // Resolving Dependencies
            var payPalAdapter = serviceProvider.GetRequiredService<IPaymentAdapter>(
              "PayPalAdapter");
            var stripeAdapter = serviceProvider.GetRequiredService<IPaymentAdapter>(
              "StripeAdapter");

            // Using the Adapters
            Console.WriteLine(payPalAdapter.Pay(100));
            Console.WriteLine(stripeAdapter.Pay(150));            
            **/

            IPayPalPayment payPalPayment = new PayPalPayment();
            var payPalAdapter = new PayPalAdapter(payPalPayment);

            IStripePayment stripePayment = new StripePayment();
            var stripeAdapter = new StripeAdapter(stripePayment);

            Console.WriteLine(payPalAdapter.Pay(100));
            Console.WriteLine(stripeAdapter.Pay(150));
        }
    
        static void Example_05()
        {
            ICompound water = new RichCompound("Water");
            water.Display();

            ICompound benzene = new RichCompound("Benzene");
            benzene.Display();

            ICompound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }
    }
}
