namespace Ecommerce.Before.Contracts
{
    using System.Collections.Generic;
    using Before.Contracts;
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<IOrderItem> orderItems);
    }
}
