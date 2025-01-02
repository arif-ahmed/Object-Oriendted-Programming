
using DIP_Demo.OrderApp.Follow.Contracts;
using System.Collections.Generic;

namespace DIP_Demo.OrderApp.Follow
{
    public class ProductService
    {
        private IProductDiscountStrategy _productDiscount;
        private IProductRepository _productRepository;

        public ProductService(IProductDiscountStrategy productDiscount, IProductRepository productRepository)
        {
            _productDiscount = productDiscount;
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> productsFromDataStore = _productRepository.FindAll();
            foreach (Product p in productsFromDataStore)
            {
                p.AdjustPrice(_productDiscount);
            }
            return productsFromDataStore;
        }
    }
}
