using Observer.CriminalSurveillanceSystem;
using Observer.Example_01;
using Observer.Structure;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Structure();
            // CriminalSurveillanceSystem();
            // Example_01();
            Console.ReadKey();
        }

        static void CriminalSurveillanceSystem()
        {
            Inspector inspector1 = new Inspector("Greg Lestrade");
            Inspector inspector2 = new Inspector("Sherlock Holmes");

            Headquarter headquarters = new Headquarter();

            inspector1.Subscribe(headquarters);
            inspector2.Subscribe(headquarters);

            headquarters.SendMessage(new Message("Catch Moriarty!"));

            headquarters.EndTransmission();
        }

        static void Example_01()
        {
            // Create IBM stock and attach investors
            var ibm = new IBM(120.00);
            // Attach 'listeners', i.e. Investors
            ibm.Attach(new Investor { Name = "Sorros" });
            ibm.Attach(new Investor { Name = "Berkshire" });
            // Fluctuating prices will notify listening investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }

        static void Structure()
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
        }
    }
}
