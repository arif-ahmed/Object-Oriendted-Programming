namespace ShapeDrawer
{
    using System;
    using Contracts;
    class Program
    {
        static void Main(string[] args)
        {
            IDrawingManager drawingManager = new CircleDrawingManager();

            IShape shape = new Rectangle();

            drawingManager.Draw(shape);

            shape = new Circle();
            drawingManager.Draw(shape);
        }
    }
}
