
namespace FilterProductDemo.Follow
{
    public class SizeFilterSpecification : ProductFilterSpecification
    {
        private readonly ProductSize _productSize;
        public SizeFilterSpecification(ProductSize productSize) 
        {
            _productSize = productSize;
        }

        protected override IEnumerable<Product> ApplyFilter(IList<Product> products)
        {
            foreach (Product product in products) 
            {
                if(product.Size == _productSize)
                    yield return product;
            }
        }
    }
}
