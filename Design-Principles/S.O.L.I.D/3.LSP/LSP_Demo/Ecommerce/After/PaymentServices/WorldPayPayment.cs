namespace Ecommerce.After.PaymentServices
{
    public class WorldPayPayment : PaymentBase
    {
        public WorldPayPayment(string accountName, string password, string productId)
        {
            AccountName = accountName;
            Password = password;
            ProductId = productId;
        }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string ProductId { get; set; }

        public override bool Refund(decimal amount, string transactionId)
        {
            WorldPayWebService worldPayWebService = new WorldPayWebService();
            string response = worldPayWebService.MakeRefund(amount, transactionId, AccountName, Password, ProductId);
            return response.Contains("Success");
        }
    }
}
