using SolidHelloWorld.interfaces;

namespace SolidHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            // ITextWriter writer = new ConsoleWriter();
            ITextWriter writer = new LogWriter(new Logger());
            IMessageCollector collector = new MessageCollector();

            MessagePublisher messagePublisher = new MessagePublisher(writer, collector);
            messagePublisher.PublishMessage();

            Console.ReadKey();
        }
    }
}
