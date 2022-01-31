namespace Ecommerce.After.PaymentServices
{
    using System;
    public class PaymentFactory
    {
        public static PaymentBase GetPaymentService(PaymentServiceType serviceType, PaymentInformation paymentInformation)
        {
            switch (serviceType)
            {
                case PaymentServiceType.PayPal:
                    return new PayPalPayment(paymentInformation.AccountName, paymentInformation.Password);
                case PaymentServiceType.WorldPay:
                    return new WorldPayPayment(paymentInformation.AccountName, paymentInformation.Password, paymentInformation.ProductId);
                default:
                    throw new NotImplementedException("No such service.");
            }
        }
    }
}
