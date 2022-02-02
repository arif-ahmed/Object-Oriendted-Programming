using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Example_01
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Stock(string symbol, double price)
    {
        protected string symbol = symbol;
        protected double price = price;
        // Event
        public event EventHandler<ChangeEventArgs> Change = null!;
        // Invoke the Change event
        public virtual void OnChange(ChangeEventArgs e)
        {
            Change?.Invoke(this, e);
        }
        public void Attach(IInvestor investor)
        {
            Change += investor.Update;
        }
        public void Detach(IInvestor investor)
        {
            Change -= investor.Update;
        }
        // Gets or sets the price
        public double Price
        {
            get => price;
            set
            {
                if (price != value)
                {
                    price = value;
                    OnChange(new ChangeEventArgs { Symbol = symbol, Price = price });
                    Console.WriteLine("");
                }
            }
        }
    }
}
