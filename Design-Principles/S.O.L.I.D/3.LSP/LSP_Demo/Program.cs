using System;

namespace LSP_Demo
{
    using Duck;
    using LSP_Demo.Duck.Violated;

    class Program
    {
        static void Main(string[] args)
        {
            Shape_Demo();
            //Employees_Demo();
            //Violated_Demo();
        }
        
        static void Shape_Demo()
        {
            Shape.ShapeDemo.Before_Demo();
            Shape.ShapeDemo.After_Demo();
        }

        static void Employees_Demo()
        {
            Employees.Employees.Before_Demo();
            Employees.Employees.After_Demo();
        }

        static void Violated_Demo()
        {

            var daffy = new Duck.Violated.Duck();
            MakeDuckSwim(daffy);

            var donald = new Duck.Violated.ElectricDuck();
            MakeDuckSwim(donald);

            // breaks LSP
            void MakeDuckSwim(Duck.Violated.IDuck duck)
            {
                if(duck is Duck.Violated.ElectricDuck)
                {
                    (duck as ElectricDuck).TurnOn();
                }

                duck.Swim();
            }
        }
    }
}
