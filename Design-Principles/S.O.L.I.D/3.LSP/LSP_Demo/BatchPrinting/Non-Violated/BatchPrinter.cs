namespace BatchPrinting.Non_Violated
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    public class BatchPrinter
    {
        public void PrintCustomersDetail(IEnumerable<ICustomerPrinter> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Print());
            }
        }
    }
}
