using System;

namespace MySimpleIOCContainer
{
    public class Class1
    {

       
        public static void Main()
        {
            //registering dependences  to Container
            var resolver = new Resolver();
            resolver.Registery<IRepository, FakeRepository>();
            resolver.Registery<PurchaseBl, PurchaseBl>();
            // Resolving dependences
            var purchaseBl = resolver.Resolve<PurchaseBl>();
            Console.WriteLine(purchaseBl.SavePurchaseOrder());
        }
    }
}
