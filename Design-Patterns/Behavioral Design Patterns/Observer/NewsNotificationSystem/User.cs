
using System;

namespace Observer.NewsNotificationSystem
{
    public class User
    {
        public void Update(object sender, NewsEventArgs eventArgs)
        {
            Console.WriteLine($"{sender.GetType()} Called");
        }
    }
}
