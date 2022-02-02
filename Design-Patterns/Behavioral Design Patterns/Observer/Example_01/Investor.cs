using System;

namespace Observer.Example_01
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class Investor : IInvestor
    {
        // Gets or sets the investor name
        public string Name { get; set; } = null!;
        // Gets or sets the stock
        public Stock Stock { get; set; } = null!;
        public void Update(object sender, ChangeEventArgs e)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", Name, e.Symbol, e.Price);
        }
    }
}
