namespace ShapeDrawer
{
    using System;
    using Contracts;
    public class CircleDrawingManager : DrawingManager
    {
        public override void DrawShape(IShape shape)
        {
            Console.WriteLine($"{shape.GetType().Name}");
        }
    }
}
