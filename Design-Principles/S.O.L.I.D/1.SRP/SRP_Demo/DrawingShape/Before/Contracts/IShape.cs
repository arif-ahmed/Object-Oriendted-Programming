namespace DrawingShape.Before.Contracts
{
    public interface IShape
    {
        void Draw(IRenderer renderer, IDrawingContext drawingContext);
    }
}