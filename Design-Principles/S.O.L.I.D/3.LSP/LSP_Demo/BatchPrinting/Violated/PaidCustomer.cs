namespace BatchPrinting.Violated
{
    public class PaidCustomer : Customer
    {
        public override string Print()
        {
            return "Paid Customer";
        }
    }
}
