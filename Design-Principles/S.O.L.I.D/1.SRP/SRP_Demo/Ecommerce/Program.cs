
using SRP.Ecommerce.Before;
using System.Collections.Generic;
using System;

namespace Ecommerce
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // Create some order items
            var items = new List<OrderItem>
            {
                new OrderItem { Identifier = "Item001", Sku = 100, Quantity = 2 },
                new OrderItem { Identifier = "Item002", Sku = 150, Quantity = 1 }
            };

            // Create a shopping cart
            var shoppingCart = new ShoppingCart
            {
                Items = items,
                CustomerEmail = "customer@example.com"
            };

            // Create payment details
            var paymentDetails = new PaymentDetails
            {
                PaymentMethod = PaymentMethod.CreditCard,
                CreditCardNumber = "1234-5678-9876-5432",
                ExpiryDate = new DateTime(2025, 12, 31),
                CardholderName = "John Doe"
            };

            // Create an Order instance
            var order = new Order();

            // Process the order
            try
            {
                Console.WriteLine("Starting checkout...");
                order.Checkout(shoppingCart, paymentDetails, notifyCustomer: true);
                Console.WriteLine("Checkout completed successfully.");
            }
            catch (OrderException ex)
            {
                Console.WriteLine($"Order processing failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
