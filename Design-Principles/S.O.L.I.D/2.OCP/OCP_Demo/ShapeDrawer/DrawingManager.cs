namespace ShapeDrawer
{
    using Contracts;

    public abstract class DrawingManager : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            DrawShape(shape);
        }

        public abstract void DrawShape(IShape shape);
    }
}
