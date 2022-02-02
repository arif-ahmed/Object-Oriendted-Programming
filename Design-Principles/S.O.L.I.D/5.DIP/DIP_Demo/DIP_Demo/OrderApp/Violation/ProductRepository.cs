
using System.Collections.Generic;

namespace DIP_Demo.OrderApp.Violation
{
    public class ProductRepository
    {
        public IEnumerable<Product> FindAll()
        {
            return new List<Product>();
        }
    }
}
