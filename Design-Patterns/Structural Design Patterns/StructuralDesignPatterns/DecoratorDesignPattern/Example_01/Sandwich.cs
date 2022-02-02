
namespace DecoratorDesignPattern.Example_01
{
    public class Sandwich : Food
    {
        public override string Description() => "Sandwich";
        public override double Cost() => 1.0;
    }
}
