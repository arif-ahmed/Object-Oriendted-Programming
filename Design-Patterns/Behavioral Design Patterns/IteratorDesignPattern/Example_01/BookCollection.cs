namespace IteratorDesignPattern.Example_01
{
    // ConcreteAggregate
    public class BookCollection : IBookCollection
    {
        private List<string> _titles = new List<string>();
        public void Add(string title)
        {
            _titles.Add(title);
        }
        public Iterator CreateIterator()
        {
            return new BookIterator(this);
        }
        public int Count => _titles.Count;
        public string this[int index]
        {
            get { return _titles[index]; }
        }
    }
}
