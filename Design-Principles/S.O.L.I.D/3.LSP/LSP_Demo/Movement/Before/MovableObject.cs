namespace LSP_Demo.Movement.Before
{
    using LSP_Demo.Movement.Before.Contracts;

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
