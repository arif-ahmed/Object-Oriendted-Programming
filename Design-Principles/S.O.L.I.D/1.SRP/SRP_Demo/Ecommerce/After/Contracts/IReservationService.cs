namespace SRP.Ecommerce.After.Contracts
{
    using System.Collections.Generic;
    using After.Contracts;
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<IOrderItem> orderItems);
    }
}
