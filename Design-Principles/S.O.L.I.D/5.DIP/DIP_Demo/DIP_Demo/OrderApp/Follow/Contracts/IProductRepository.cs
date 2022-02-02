
using System.Collections.Generic;

namespace DIP_Demo.OrderApp.Follow.Contracts
{
    public interface IProductRepository
    {
        IEnumerable<Product> FindAll();
    }
}
