using FilterProductDemo.Follow;

namespace FilterProductDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Violation_Demo();
            Follow_Demo();
            Console.ReadKey();
        }

        static void Violation_Demo()
        {
            Violation.ProductFilter filterProduct = new Violation.ProductFilter();

            IList<Product> products = new List<Product>() 
            {
                new Product(ProductColor.Blue), 
                new Product(ProductColor.Yellow), 
                new Product(ProductColor.Yellow), 
                new Product(ProductColor.Red), 
                new Product(ProductColor.Blue)
            };

            int foundCount = 0;

            foreach (var product in filterProduct.GetProductsByColor(products, ProductColor.Blue)) 
            { 
                foundCount++; 
            }

            Console.WriteLine($"Expected Blue Product: {2}, Found Blue Product: {foundCount}");
        }

        static void Follow_Demo() 
        {
            Follow.ProductFilter filterProduct = new Follow.ProductFilter();

            IList<Product> products = new List<Product>()
            {
                new Product(ProductColor.Blue),
                new Product(ProductColor.Yellow),
                new Product(ProductColor.Yellow),
                new Product(ProductColor.Red),
                new Product(ProductColor.Blue)
            };

            int foundCount = 0;

            foreach (var product in filterProduct.GetByFilter(products, new ColorFilterSpecification(ProductColor.Blue)))
            {
                foundCount++;
            }

            Console.WriteLine($"Expected Blue Product: {2}, Found Blue Product: {foundCount}");
        }
    }
}
