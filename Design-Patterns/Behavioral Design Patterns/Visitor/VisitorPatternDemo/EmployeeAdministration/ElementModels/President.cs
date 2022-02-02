using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPatternDemo.EmployeeAdministration.ElementModels
{
    public class President : Employee
    {
        public President(string name)
            : base(name, 50000, 20)
        {
        }
    }
}
