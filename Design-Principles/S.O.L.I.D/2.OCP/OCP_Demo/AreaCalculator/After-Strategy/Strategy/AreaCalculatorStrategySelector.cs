namespace AreaCalculator.After_Strategy.Strategy
{
    using System.Linq;
    using System.Collections.Generic;
    public class AreaCalculatorStrategySelector
    {
        List<IShapeAreaCalculatorStrategy> shapeAreaCalculatorStrategies = new List<IShapeAreaCalculatorStrategy>()
        {
            new RectangleAreaCalculatorStrategy(),
            new CircleAreaCalculatorStrategy()
        };
        public AreaCalculatorStrategySelector()
        {
        }

        public double CalculateArea(IShape shape)
        {
            var shapeAreaCalculatorStrategy = shapeAreaCalculatorStrategies.FirstOrDefault(x => x.Identifier.GetType() == shape.GetType());
            return shapeAreaCalculatorStrategy.Area(shape);        
        }
    }
}
