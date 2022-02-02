using System;

namespace Observer.NewsNotificationSystem
{
    public class NewsAgency
    {
        public EventHandler<SportsNewsArgs> SportsNewsBroadCaster { get; set; }
    
        public void Attach(User user)
        {
            SportsNewsBroadCaster += user.Update;
        }

        public void BroadcastNews(string title, string summary)
        {
            SportsNewsBroadCaster?.Invoke(this, new SportsNewsArgs { Title = title, Summary = summary });
        }
    }
}
