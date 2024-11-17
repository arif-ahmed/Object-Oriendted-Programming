using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo.Example_04
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class VicePresident : Approver
    {
        public override void PurchaseHandler(object sender, PurchaseEventArgs e)
        {
            if (e.Purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, e.Purchase.Number);
            }
            else
            {
                Successor?.PurchaseHandler(this, e);
            }
        }
    }

}
