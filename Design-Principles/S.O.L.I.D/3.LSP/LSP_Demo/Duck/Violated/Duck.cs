using System;

namespace LSP_Demo.Duck.Violated
{
    public class Duck : IDuck
    {
        public void Swim()
        {
            Console.WriteLine("Duck Swimming");
        }
    }
}
