using System;

namespace Observer.Example_01
{
    public class ChangeEventArgs : EventArgs
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
    }
}
