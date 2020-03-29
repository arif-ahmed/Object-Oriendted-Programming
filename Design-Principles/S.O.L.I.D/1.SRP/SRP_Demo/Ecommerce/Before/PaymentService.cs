namespace SRP.Ecommerce.Before
{
    using System;
    public class PaymentService
    {
        public string CardNumber { get; set; }
        public string Credentials { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
        public decimal AmountToCharge { get; set; }
        public void Charge()
        {
            try
            {
                Console.WriteLine($"Account Detail: {NameOnCard} {CardNumber}");
                Console.WriteLine($"{AmountToCharge} debited from {CardNumber} Card");
            }
            catch
            {
                throw new AccountBalanceMismatchException();
            }
        }
    }
}
