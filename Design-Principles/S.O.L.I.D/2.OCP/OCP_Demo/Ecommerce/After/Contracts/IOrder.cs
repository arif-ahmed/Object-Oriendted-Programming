﻿namespace Ecommerce.After.Contracts
{
    public interface IOrder
    {
        IShoppingCart ShoppingCart { get; }
        void Checkout();
    }
}
