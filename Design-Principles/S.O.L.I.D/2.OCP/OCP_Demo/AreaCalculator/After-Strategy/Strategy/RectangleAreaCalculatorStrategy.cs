namespace AreaCalculator.After_Strategy.Strategy
{
    public class RectangleAreaCalculatorStrategy : IShapeAreaCalculatorStrategy
    {
        public IShape Identifier { get; set; } = new Rectangle();

        public double Area(IShape shape)
        {
            Rectangle rectangle = (Rectangle)shape;
            return rectangle.Height * rectangle.Width;
        }
    }
}
