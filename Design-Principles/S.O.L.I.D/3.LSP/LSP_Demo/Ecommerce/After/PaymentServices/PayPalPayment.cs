namespace Ecommerce.After.PaymentServices
{
    public class PayPalPayment : PaymentBase
    {
        public PayPalPayment(string accountName, string password)
        {
            AccountName = accountName;
            Password = password;
        }
        public string AccountName { get; set; }
        public string Password { get; set; }

        public override bool Refund(decimal amount, string transactionId)
        {
            PayPalWebService payPalWebService = new PayPalWebService();
            string token = payPalWebService.GetTransactionToken(AccountName, Password);
            string response = payPalWebService.MakeRefund(amount, transactionId, token);
            return response.Contains("Auth");
        }
    }
}
