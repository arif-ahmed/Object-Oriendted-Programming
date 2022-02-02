namespace AdapterDesignPattern.Example_04
{
    // PayPal Gateway
    public interface IPayPalPayment
    {
        string MakePayment(decimal amount);
    }
}
