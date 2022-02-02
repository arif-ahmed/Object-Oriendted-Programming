namespace FilterProductDemo.Follow
{
    public class ColorFilterSpecification : ProductFilterSpecification
    {
        private readonly ProductColor _productColor;

        public ColorFilterSpecification(ProductColor productColor)
        {
            _productColor = productColor;
        }

        protected override IEnumerable<Product> ApplyFilter(IList<Product> products)
        {
            foreach (Product product in products)
            {
                if (product.Color == _productColor)
                    yield return product;
            }
        }
    }
}
