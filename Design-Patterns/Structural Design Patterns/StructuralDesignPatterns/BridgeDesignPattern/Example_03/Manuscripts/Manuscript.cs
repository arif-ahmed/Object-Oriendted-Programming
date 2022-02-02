namespace Example_03.Manuscripts
{
    using Example_03.Formatters;

    internal abstract class Manuscript
    {
        protected readonly IFormatter Formatter;

        protected Manuscript(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public abstract void Print();
    }
}
