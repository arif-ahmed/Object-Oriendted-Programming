
namespace PaintTool.Follow
{
    public class Painter
    {
        private IEnumerable<Shape> shapes;

        public void DrawAll()
        {
            ICanvas canvas = GetCanvas();

            foreach (Shape shape in shapes)
            {
                shape.Draw(canvas);
            }
        }

        private ICanvas GetCanvas()
        {
            return new Canvas();
        }
    }
}
