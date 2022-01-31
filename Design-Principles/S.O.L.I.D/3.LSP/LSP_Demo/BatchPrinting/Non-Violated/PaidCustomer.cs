namespace BatchPrinting.Non_Violated
{
    using Contracts;
    public class PaidCustomer : Customer, ICustomerPrinter
    {
        public string Print()
        {
            return "Paid Customer";
        }
    }
}
