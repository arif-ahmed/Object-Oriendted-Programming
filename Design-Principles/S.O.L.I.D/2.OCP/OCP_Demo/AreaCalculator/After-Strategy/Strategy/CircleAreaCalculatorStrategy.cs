namespace AreaCalculator.After_Strategy.Strategy
{
    using System;
    class CircleAreaCalculatorStrategy : IShapeAreaCalculatorStrategy
    {
        public IShape Identifier { get; set; } = new Circle();

        public double Area(IShape shape)
        {
            Circle circle = (Circle)(shape);
            return Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}
