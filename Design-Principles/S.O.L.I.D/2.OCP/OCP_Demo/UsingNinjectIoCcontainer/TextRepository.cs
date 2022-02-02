namespace MySimpleIOCContainer
{
    /// <summary>
    /// Responsible for savaing data to text file
    /// </summary>
    public class TextRepository : IRepository
    {
        private int _counter = 0;
        public string Save()
        {
            _counter++;
            return string.Format("I am saving data to TextFile {0}.", _counter);
        }
    }
}