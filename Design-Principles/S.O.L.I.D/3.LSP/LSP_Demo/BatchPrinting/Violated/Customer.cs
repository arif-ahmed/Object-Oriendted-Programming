namespace BatchPrinting.Violated
{
    public abstract class Customer
    {
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public abstract string Print();
    }
}
