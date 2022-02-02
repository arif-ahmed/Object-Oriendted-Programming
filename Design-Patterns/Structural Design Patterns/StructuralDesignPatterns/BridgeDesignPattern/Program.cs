using BridgeDesignPattern.Example_01.Applied;
using Example_03.Formatters;
using Example_03.Manuscripts;

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

        static void Example_03()
        {
            var documents = new List<Manuscript>();
            var formatter = new FancyFormatter(); // new BackwardsFormatter();

            var faq = new Faq(formatter) { Title = "The Bridge Pattern FAQ" };
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
            documents.Add(faq);

            var book = new Book(formatter)
            {
                Title = "Lots of Patterns",
                Author = "John Sonmez",
                Text = "Blah blah blah..."
            };
            documents.Add(book);

            var paper = new TermPaper(formatter)
            {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah blah blah...",
                References = "GOF"
            };
            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }
        }
    }
}
