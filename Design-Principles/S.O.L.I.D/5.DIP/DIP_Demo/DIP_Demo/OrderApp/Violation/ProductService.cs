
using System.Collections.Generic;

namespace DIP_Demo.OrderApp.Violation
{
    public class ProductService
    {
        private ProductDiscount _productDiscount;
        private ProductRepository _productRepository;

        public ProductService()
        {
            _productDiscount = new ProductDiscount();
            _productRepository = new ProductRepository();
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
