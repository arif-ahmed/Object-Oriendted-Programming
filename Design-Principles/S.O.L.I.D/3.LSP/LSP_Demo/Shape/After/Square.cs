namespace LSP_Demo.Shape.After
{
    public class Square : Shape
    {
        public decimal Side { get; set; }

        public override decimal Area => Side * Side;
    }
}
