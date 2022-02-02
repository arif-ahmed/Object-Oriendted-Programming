using BridgeDesignPattern.Example_01.Applied;

namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example_01();
            Console.ReadKey();
        }

        static void Example_01() 
        {
            // Drawing a red circle
            Shape redCircle = new Circle(new Red());
            redCircle.Draw();  // Output: Drawing a circle. Applying red color.

            // Drawing a blue square
            Shape blueSquare = new Square(new Blue());
            blueSquare.Draw();  // Output: Drawing a square. Applying blue color.
        }
    }
}
