using System;

namespace Observer.NewsNotificationSystem
{
    public class NewsEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
