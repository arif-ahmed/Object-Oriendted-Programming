namespace AreaCalculator.After
{
    public class Rectangle: IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Height * Width;
        }
    }
}
