namespace AreaCalculator.After_Strategy
{
    using Strategy;
    public class AreaCalculator
    {
        private AreaCalculatorStrategySelector _areaCalculatorStrategySelector;

        public AreaCalculator(AreaCalculatorStrategySelector areaCalculatorStrategySelector)
        {
            _areaCalculatorStrategySelector = areaCalculatorStrategySelector;
        }

        public double Area(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area  +=_areaCalculatorStrategySelector.CalculateArea(shape);
            }

            return area;
        }
    }
}
