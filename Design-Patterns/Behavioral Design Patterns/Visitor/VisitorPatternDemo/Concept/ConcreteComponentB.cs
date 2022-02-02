
namespace VisitorPatternDemo.Concept
{
    public class ConcreteComponentB : IComponent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
