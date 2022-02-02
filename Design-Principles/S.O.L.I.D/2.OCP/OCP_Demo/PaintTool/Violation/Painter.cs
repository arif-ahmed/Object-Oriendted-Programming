namespace PaintTool.Violation
{
    public class Painter
    {
        private IEnumerable<Line> lines;
        private IEnumerable<Rectangle> rectangles;

        public void DrawAll()
        {
            ICanvas canvas = GetCanvas();

            foreach (Line line in lines) 
            {
                line.Draw(canvas);
            }

            foreach (Rectangle rectangle in rectangles)
            {
                rectangle.Draw(canvas);
            }
        }

        private ICanvas GetCanvas()
        {
            return new Canvas();
        }
    }
}
