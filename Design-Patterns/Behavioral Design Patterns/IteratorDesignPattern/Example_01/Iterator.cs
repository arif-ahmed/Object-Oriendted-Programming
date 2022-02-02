namespace IteratorDesignPattern.Example_01
{
    // Iterator
    public abstract class Iterator
    {
        public abstract string First();
        public abstract string Next();
        public abstract bool IsDone();
        public abstract string CurrentItem();
    }
}
