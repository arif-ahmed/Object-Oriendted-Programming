namespace MySimpleIOCContainer
{
    class FakeRepository : IRepository
    {
        public string Save()
        {
            return "I am from fake save";
        }
    }
}