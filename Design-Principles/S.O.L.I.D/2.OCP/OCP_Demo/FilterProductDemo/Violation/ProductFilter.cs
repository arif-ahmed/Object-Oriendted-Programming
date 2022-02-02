namespace FilterProductDemo.Violation
{
    public class ProductFilter
    {
        public IEnumerable<Product> GetProductsByColor(IList<Product> products, ProductColor productColor)
        {
            foreach (var product in products) 
            {
                if(product.Color == productColor)
                    yield return product;
            }
        }

        public IEnumerable<Product> GetProductsBySize(IList<Product> products, ProductSize productSize)
        {
            foreach (var product in products)
            {
                if (product.Size == productSize)
                    yield return product;
            }
        }

        public IEnumerable<Product> GetProductsByColorAndSize(IList<Product> products, ProductColor productColor, ProductSize productSize)
        {
            foreach (var product in products)
            {
                if (product.Color == productColor && product.Size == productSize)
                    yield return product;
            }
        }
    }
}
