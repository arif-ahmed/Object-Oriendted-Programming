namespace Details_Printer.LSP_Non_Violated
{
    using System;
    public class Employee
    {
        public Employee(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
