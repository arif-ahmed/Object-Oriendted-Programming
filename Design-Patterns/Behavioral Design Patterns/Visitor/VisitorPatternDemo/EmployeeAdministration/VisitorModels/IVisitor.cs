using VisitorPatternDemo.EmployeeAdministration.ElementModels;

namespace VisitorPatternDemo.EmployeeAdministration.VisitorModels
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
