using LSP_Demo.Shape.After;
using System;

namespace LSP_Demo.Shape
{
    public class ShapeDemo
    {
        public static void Before_Demo()
        {
            Before.Square square = new Before.Square { Height = 5, Width = 5 };
            Print(square);

            Before.Rectangle rectangle = square;
            rectangle.Width = 6;
            rectangle.Height = 5;

            Print(rectangle);

            void Print(Before.Shape shape)
            {
                Console.WriteLine(shape.Area);
            }
        }

        public static void After_Demo()
        {
            After.Shape shape = new After.Square { Side = 5 };
            Print();

            shape = new After.Rectangle { Height = 5, Width = 6 };
            Print();

            void Print()
            {
                Console.WriteLine(shape.Area);
            }
        }
    }
}
