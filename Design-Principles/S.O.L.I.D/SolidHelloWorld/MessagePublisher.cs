
using SolidHelloWorld.interfaces;

namespace SolidHelloWorld
{
    public class MessagePublisher
    {
        public MessagePublisher(ITextWriter textWriter, IMessageCollector messageCollector) 
        {
            if (textWriter == null)
                throw new ArgumentException("Text Writer");
            TextWriter = textWriter;
            
            if(messageCollector == null)
                throw new ArgumentException("Message Collector");
            MessageCollector = messageCollector;
        }

        public ITextWriter TextWriter { get; set; }
        public IMessageCollector MessageCollector { get; set; }
        public void PublishMessage() 
        {
            string message = MessageCollector.GetMessageFromSource();
            TextWriter.Write(message);
        }
    }
}
