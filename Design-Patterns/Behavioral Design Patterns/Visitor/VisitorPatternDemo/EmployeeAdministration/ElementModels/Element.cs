using System;
using System.Collections.Generic;
using System.Text;
using VisitorPatternDemo.EmployeeAdministration.VisitorModels;

namespace VisitorPatternDemo.EmployeeAdministration.ElementModels
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
