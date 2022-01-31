namespace CommandPatternDemo
{
    using System;
    using CommandPatternDemo.DemoOne;

    class Program
    {
        static void Main(string[] args)
        {
            DemoOne();
        }
        
        static void DemoOne()
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);

            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));

            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));

            Console.WriteLine(product);
            Console.WriteLine();

            Execute(modifyPrice, new ProductCommand(product, PriceAction.Increase, 2500));

            modifyPrice.UndoActions();
            Console.WriteLine(product);

            modifyPrice.UndoActions();
            Console.WriteLine(product);


            void Execute(ModifyPrice modifyPrice, ICommand productCommand) 
            {
                modifyPrice.SetCommand(productCommand);
                modifyPrice.Invoke();
            }
        }
    }
}
