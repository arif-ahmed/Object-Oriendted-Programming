namespace FilterProductDemo.Follow
{
    public class ProductFilter
    {
        public IEnumerable<Product> GetByFilter(IList<Product> products, ProductFilterSpecification productFilterSpecification)
        {
            return productFilterSpecification.Filter(products);
        }
    }
}
