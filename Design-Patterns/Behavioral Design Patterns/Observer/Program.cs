using Observer.CriminalSurveillanceSystem;
using Observer.Example_01;
using Observer.NewsNotificationSystem;
using Observer.Structure;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Structure();
            // CriminalSurveillanceSystem();
            // Example_01();
            NewsNotificationSystem();
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
        static void NewsNotificationSystem() 
        {
            NewsAgency newsAgency = new NewsAgency();
            User user = new User();
            newsAgency.Attach(user);
            newsAgency.BroadcastNews("HH", "HHH");

            /** 
             *             // Create the subject (News Agency)
            var newsAgency = new NewsAgency();

            // Create observers (Subscribers)
            var sportsSubscriber = new Subscriber("Sports Enthusiast");
            var weatherSubscriber = new Subscriber("Meteorologist");
            var politicsSubscriber = new Subscriber("Political Analyst");

            // Subscribe to topics
            newsAgency.Subscribe("Sports", sportsSubscriber);
            newsAgency.Subscribe("Weather", weatherSubscriber);
            newsAgency.Subscribe("Politics", politicsSubscriber);

            // Publish news updates
            newsAgency.PublishNews("Sports", "Breaking: Local team wins the championship!");
            newsAgency.PublishNews("Weather", "Alert: Heavy rain expected tomorrow.");
            newsAgency.PublishNews("Politics", "Election results are out!");

            // Unsubscribe a subscriber and publish more news
            newsAgency.Unsubscribe("Weather", weatherSubscriber);
            newsAgency.PublishNews("Weather", "Update: Thunderstorm warning issued.");

            Console.ReadLine();
            **/
        }
    }
}
