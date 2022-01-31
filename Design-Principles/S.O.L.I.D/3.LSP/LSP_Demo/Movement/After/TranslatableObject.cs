namespace LSP_Demo.Movement.After
{
    using LSP_Demo.Movement.After.Contracts;

    public abstract class TranslatableObject : IMovable, ITranslatable
    {
        public abstract void Translate();

        public virtual void Move()
        {
            Translate();
        }
    }
}
