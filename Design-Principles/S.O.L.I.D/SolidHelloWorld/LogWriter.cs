
using SolidHelloWorld.interfaces;

namespace SolidHelloWorld
{
    public class LogWriter : ITextWriter
    {
        ILogger logger;
        public LogWriter(ILogger logger) 
        {
            this.logger = logger;
        }

        public void Write(string content)
        {
            logger.Log(content);
        }
    }
}
