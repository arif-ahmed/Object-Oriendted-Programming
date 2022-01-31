using System;
using System.Collections.Generic;
using System.Text;

namespace BatchPrinting.Violated
{
    public class GoldCustomer : Customer
    {
        public override string Print()
        {
            return "Gold Customer";
        }
    }
}
