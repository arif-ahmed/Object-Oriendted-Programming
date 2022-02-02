namespace MySimpleIOCContainer
{
    /// <summary>
    /// Responsible for savaing data to text file
    /// </summary>
    public class TextRepository : IRepository
    {
        public string Save()
        {
            return "I am saving data to TextFile.";
        }
    }
}