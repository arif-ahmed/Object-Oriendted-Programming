using IteratorDesignPattern.Example_01;

namespace IteratorDesignPattern
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
            // Client
            var books = new BookCollection();
            books.Add("Design Patterns");
            books.Add("Clean Code");
            books.Add("Refactoring");
            var iterator = books.CreateIterator();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.CurrentItem());
                iterator.Next();
            }
        }
    }
}
