using System;

namespace LSP_Demo.Employees.After
{
    public class Employee
    {
        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
