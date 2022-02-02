using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo.EmployeeAdministration.ElementModels
{
    public class Director : Employee
    {
        public Director(string name)
            : base(name, 35000, 16)
        {
        }
    }
}
