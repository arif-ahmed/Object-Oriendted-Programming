namespace DIP_Demo.OrderProcessing.Refactored.Contracts
{
    public interface IDiscountCalculator
    {
        decimal CalculateDiscount(Order order);
    }
}
