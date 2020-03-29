namespace LoggingSystem.Before
{
    public class Logger
    {
        public void Log(string message, LogTarget logTarget)
        {
            if (logTarget == LogTarget.File)
            {
                LogDataToFile(message);
            }
            else //if log target is database
            {
                LogDataToDB(message);
            }
        }

        private void LogDataToFile(string message)
        {
            //Code to write log messages to a file
        }

        private void LogDataToDB(string message)
        {
            //Code to write log messages to a database table
        }
    }
}
