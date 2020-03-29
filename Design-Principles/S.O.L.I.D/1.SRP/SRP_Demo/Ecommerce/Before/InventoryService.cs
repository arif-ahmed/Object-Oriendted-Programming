namespace SRP.Ecommerce.Before
{
    using System;
    public class InventoryService
    {
        public void Reserve(string identifier, int quantity)
        {
            try
            {
                Console.WriteLine($"{quantity} {identifier} removed from Inventory");
            }
            catch
            {
                throw new InsufficientInventoryException();
            }
        }
    }
}
