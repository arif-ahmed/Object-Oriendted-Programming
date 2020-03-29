namespace AreaCalculator.After
{
    using System;
    public class Circle: IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Sqrt(Radius);
        }
    }
}
