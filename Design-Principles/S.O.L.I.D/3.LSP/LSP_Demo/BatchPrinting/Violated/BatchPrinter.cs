namespace BatchPrinting.Violated
{
    using System;
    using System.Collections.Generic;
    public class BatchPrinter
    {
        public void PrintCustomersDetail(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Print());
            }
        }
    }
}
