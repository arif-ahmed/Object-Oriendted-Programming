
using DIP_Demo.OrderApp.Follow.Contracts;
using System.Collections.Generic;

namespace DIP_Demo.OrderApp.Follow
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> FindAll()
        {
            return new List<Product>();
        }
    }
}
