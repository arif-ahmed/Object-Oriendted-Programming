namespace OrderProcessing.Follow.Contracts
{
    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(Order order);
    }
}
