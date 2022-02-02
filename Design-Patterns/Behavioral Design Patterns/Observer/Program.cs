using Observer.CriminalSurveillanceSystem;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Inspector inspector1 = new Inspector("Greg Lestrade");
            Inspector inspector2 = new Inspector("Sherlock Holmes");

            Headquarter headquarters = new Headquarter();

            inspector1.Subscribe(headquarters);
            inspector2.Subscribe(headquarters);

            headquarters.SendMessage(new Message("Catch Moriarty!"));

            headquarters.EndTransmission();


            Console.ReadKey();
        }
    }
}
