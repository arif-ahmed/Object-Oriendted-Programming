namespace Ecommerce.Before
{
    using Contracts;
    public class CashOrder : Order
    {
        public CashOrder(IShoppingCart shoppingCart, IReservationService reservationService): base(shoppingCart, reservationService)
        {
        }
    }
}
