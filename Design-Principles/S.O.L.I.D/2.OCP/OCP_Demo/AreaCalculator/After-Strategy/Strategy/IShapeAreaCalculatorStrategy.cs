namespace AreaCalculator.After_Strategy.Strategy
{
    public interface IShapeAreaCalculatorStrategy
    {
        IShape Identifier { get; set; }
        double Area(IShape shape);
    }
}
