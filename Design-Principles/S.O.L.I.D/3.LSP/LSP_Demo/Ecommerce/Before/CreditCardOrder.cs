namespace Ecommerce.Before
{
    using Contracts;
    public class CreditCardOrder: Order
    {
        private readonly IPaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;
        public CreditCardOrder(IShoppingCart shoppingCart, IReservationService reservationService,IPaymentDetails paymentDetails,IPaymentService paymentService): base(shoppingCart, reservationService)
        {
            _paymentDetails = paymentDetails;
            _paymentService = paymentService;
        }

        public override void Checkout()
        {
            _paymentService.ProcessCreditCard(_paymentDetails, ShoppingCart.TotalAmount);
            base.Checkout();
        }
    }
}
