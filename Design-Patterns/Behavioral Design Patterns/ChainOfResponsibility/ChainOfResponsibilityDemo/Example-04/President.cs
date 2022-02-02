using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_04
{
    /// <summary>
    /// The 'ConcreteHandler' clas
    /// </summary>
    public class President : Approver
    {
        public override void PurchaseHandler(object sender, PurchaseEventArgs e)
        {
            if (e.Purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    sender.GetType().Name, e.Purchase.Number);
            }
            else if (Successor != null)
            {
                Successor.PurchaseHandler(this, e);
            }
            else
            {
                Console.WriteLine(
                    "Request# {0} requires an executive meeting!",
                    e.Purchase.Number);
            }
        }
    }
}
