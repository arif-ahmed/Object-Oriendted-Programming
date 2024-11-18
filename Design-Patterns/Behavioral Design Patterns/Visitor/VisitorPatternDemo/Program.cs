using System;
using System.Collections.Generic;
using VisitorPatternDemo.Concept;
using VisitorPatternDemo.EmployeeAdministration.ElementModels;
using VisitorPatternDemo.EmployeeAdministration.VisitorModels;

namespace VisitorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConceptDemo();
        }

        static void EmployeeAdministrationDemo()
        {
            var employees = new List<Employee>
            {
                new Clerk("Peter"),
                new Director("Nasko"),
                new President("Georgi")
            };

            EmployeeAdministration.VisitorModels.IVisitor bonusCalculator = new BonusCalculator();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee Name: {employee.Name}");
                Console.WriteLine($"Salary Without Bonus: {employee.Income}");
                employee.Accept(bonusCalculator);
                Console.WriteLine($"Salary With Bonus: {employee.Income}");

                Console.WriteLine();
            }
        }
    
        static void ConceptDemo()
        {
            IComponent componentA = new ConcreteComponentA();
            IComponent componentB = new ConcreteComponentB();

            Concept.IVisitor concreteVisitorA = new ConcreteVisitorA();
            Concept.IVisitor concreteVisitorB = new ConcreteVisitorB();

            componentA.Accept(concreteVisitorA);
        }
    }
}
