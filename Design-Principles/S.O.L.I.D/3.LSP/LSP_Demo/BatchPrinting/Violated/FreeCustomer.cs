namespace BatchPrinting.Violated
{
    public class FreeCustomer : Customer
    {
        public override string Print()
        {
            throw new System.NotImplementedException();
        }
    }
}
