namespace AreaCalculator.After
{
    public class AreaCalculator
    {
        public double Area(IShape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }
    }
}
