namespace SRP.Ecommerce.After
{
    using Contracts;
    public class OnlineOrder : Order
    {
        private readonly IPaymentDetails _paymentDetails;
        private readonly IPaymentService _paymentService;
        private readonly INotificationService _notificationService;
        public OnlineOrder(IShoppingCart shoppingCart, IReservationService reservationService, IPaymentDetails paymentDetails, IPaymentService paymentService, INotificationService notificationService): base(shoppingCart, reservationService)
        {
            _paymentDetails = paymentDetails;
            _paymentService = paymentService;
            _notificationService = notificationService;
        }

        public override void Checkout()
        {
            _paymentService.ProcessCreditCard(_paymentDetails, ShoppingCart.TotalAmount);
            _notificationService.NotifyCustomerOrderCreated(ShoppingCart.CustomerEmail);
            base.Checkout();
        }
    }
}
