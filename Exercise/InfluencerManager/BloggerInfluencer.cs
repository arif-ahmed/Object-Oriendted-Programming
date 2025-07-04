﻿namespace InfluencerManager
{
    public class BloggerInfluencer : Influencer
    {
        private const double engagementRate = 2.0;
        public BloggerInfluencer(string username, int followers) 
            : base(username, followers, engagementRate)
        {
        }

        public override int CalculateCampaignPrice()
        {
            int result = 0;

            result = (int)Math.Floor(Followers * EngagementRate * 0.2);

            return result;
        }
    }
}
