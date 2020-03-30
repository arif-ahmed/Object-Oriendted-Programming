namespace Ecommerce.Before
{
    using Contracts;

    public abstract class Order
    {
        private readonly IReservationService _reservationService;

        public Order(IShoppingCart shoppingCart, IReservationService reservationService)
        {
            ShoppingCart = shoppingCart;
            _reservationService = reservationService;
        }

        public IShoppingCart ShoppingCart { get; }

        public virtual void Checkout()
        {
            _reservationService.ReserveInventory(ShoppingCart.Items);
        }
    }
}
