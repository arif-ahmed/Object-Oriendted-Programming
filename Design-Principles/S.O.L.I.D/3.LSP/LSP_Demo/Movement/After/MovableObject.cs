namespace LSP_Demo.Movement.After
{
    using LSP_Demo.Movement.After.Contracts;

    public abstract class MovableObject : IMovable
    {
        public abstract void Translate();

        public abstract void Rotate();

        public virtual void Move()
        {
            this.Translate();
            this.Rotate();
        }
    }
}
