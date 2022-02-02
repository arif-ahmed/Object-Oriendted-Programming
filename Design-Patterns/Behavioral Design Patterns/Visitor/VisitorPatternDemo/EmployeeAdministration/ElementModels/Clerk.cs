using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo.EmployeeAdministration.ElementModels
{
    public class Clerk : Employee
    {
        public Clerk(string name) : base(name, 25000, 14)
        {
        }
    }
}
