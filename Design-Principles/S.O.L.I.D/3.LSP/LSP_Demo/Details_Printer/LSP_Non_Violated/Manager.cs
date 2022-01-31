namespace Details_Printer.LSP_Non_Violated
{
    using System;
    using System.Collections.Generic;
    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(string.Join(Environment.NewLine, Documents));
        }
    }
}
