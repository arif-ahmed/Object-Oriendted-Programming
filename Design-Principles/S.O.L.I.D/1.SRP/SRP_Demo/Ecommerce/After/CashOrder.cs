namespace SRP.Ecommerce.After
{
    using Contracts;
    public class CashOrder : Order
    {
        public CashOrder(IShoppingCart shoppingCart, IReservationService reservationService): base(shoppingCart, reservationService)
        {
        }
    }
}
