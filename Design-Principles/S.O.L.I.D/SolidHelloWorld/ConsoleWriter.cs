using SolidHelloWorld.interfaces;

namespace SolidHelloWorld
{
    public class ConsoleWriter : ITextWriter
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
