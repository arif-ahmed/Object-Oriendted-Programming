using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using MySimpleIOCContainer;

namespace UsingNinjectIoCcontainer
{
    public class Class1
    {
        public static void Main()
        {
            //Using Container

            //Registering dependences
            //You dont need to Bind PurchaseBl because it automatically binds concrete type
            var kernel = new StandardKernel();
            kernel.Bind<IRepository>().To<TextRepository>().InSingletonScope();
            
            

            //resolving dependences
            //Out from kernel
            kernel.Rebind<IRepository>().To<Repository>();
            var purchaseBl = kernel.Get<PurchaseBl>();
            Console.WriteLine(purchaseBl.SavePurchaseOrder());

            var purchaseBl2 = kernel.Get<PurchaseBl>();
            Console.WriteLine(purchaseBl2.SavePurchaseOrder());

        }
    }
}
