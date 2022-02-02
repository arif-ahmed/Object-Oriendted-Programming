
using VisitorPatternDemo.EmployeeAdministration.ElementModels;

namespace VisitorPatternDemo.EmployeeAdministration.VisitorModels
{
    public class BonusCalculator : IVisitor
    {
        public void Visit(Element element)
        {
            if(element is Employee employee)
            {
                employee.Income = employee.Income * 3;
            }

            if (element is Clerk clerk)
            {
                clerk.Income = clerk.Income * 4;
            }

            if (element is Director director)
            {
                director.Income = director.Income * 2;
            }

            if (element is President president)
            {
                president.Income = president.Income * 1;
            }
        }
    }
}
