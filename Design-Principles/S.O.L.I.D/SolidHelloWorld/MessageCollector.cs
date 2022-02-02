
using SolidHelloWorld.interfaces;

namespace SolidHelloWorld
{
    public class MessageCollector : IMessageCollector
    {
        public string GetMessageFromSource()
        {
            string content = Console.ReadLine();
            return content;        
        }
    }
}
