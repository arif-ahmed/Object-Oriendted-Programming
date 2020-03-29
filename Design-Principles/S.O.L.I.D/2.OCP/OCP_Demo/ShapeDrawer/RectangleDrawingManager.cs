namespace ShapeDrawer
{
    using System;
    using Contracts;

    public class RectangleDrawingManager : DrawingManager
    {
        public override void DrawShape(IShape shape)
        {
            Console.WriteLine($"{shape.GetType()}");
        }
    }
}
