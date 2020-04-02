namespace BatchPrinting.Non_Violated
{
    using Contracts;
    public class GoldCustomer : Customer, ICustomerPrinter
    {
        public string Print()
        {
            return "Gold Customer";
        }
    }
}
