namespace LSP_Demo.Movement.After
{
    using LSP_Demo.Movement.After.Contracts;
    public abstract class RotatableObject : IMovable, IRotatable
    {

        public virtual void Move() 
        {
            Rotate();
        }

        public abstract void Rotate();
    }
}
