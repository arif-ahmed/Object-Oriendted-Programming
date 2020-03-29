namespace LoggingSystem.After
{
    public class ObjectFactory
    {
        public static Logger GetLogger(LogTarget logTarget)
        {
            switch (logTarget)
            {
                case LogTarget.File:
                    return new FileLogger();

                case LogTarget.Database:
                    return new DBLogger();

                default:
                    return null;
            }
        }
    }
}
