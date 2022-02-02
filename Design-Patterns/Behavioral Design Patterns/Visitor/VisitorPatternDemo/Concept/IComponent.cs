namespace VisitorPatternDemo.Concept
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
