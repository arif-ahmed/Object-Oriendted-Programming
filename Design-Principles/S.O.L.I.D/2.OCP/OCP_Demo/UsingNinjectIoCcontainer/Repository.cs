namespace MySimpleIOCContainer
{
    /// <summary>
    /// Responsible for saving data to Database
    /// </summary>
    public class Repository : IRepository
    {
        public string Save()
        {
            return "I am saving data to Database.";
        }
    }
}
