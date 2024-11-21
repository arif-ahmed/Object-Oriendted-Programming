namespace BridgeDesignPattern.Example_01.Applied
{
    public abstract class Shape
    {
        protected IColor color;
        protected Shape(IColor color) 
        {
            this.color = color;
        }
        public abstract void Draw();

    }
}
