namespace BridgeDesignPattern.Example_01.Applied
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)  
        {
        }
        public override void Draw()
        {
            color.ApplyColor();
        }
    }
}
