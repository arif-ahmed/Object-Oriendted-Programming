namespace FilterProductDemo
{
    public class Product
    {
        public Product(ProductColor color) 
        { 
            this.Color = color; 
        }
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }
    }
}
