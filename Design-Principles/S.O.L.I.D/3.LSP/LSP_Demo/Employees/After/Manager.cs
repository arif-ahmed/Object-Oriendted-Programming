namespace LSP_Demo.Employees.After
{
    using System;
    using System.Collections.Generic;
    public class Manager : Employee
    {
        public IEnumerable<string> Documents { get; set; }

        public override void Print()
        {
            base.Print();

            foreach (var document in Documents)
            {
                Console.WriteLine(document);
            }
        }
    }
}
