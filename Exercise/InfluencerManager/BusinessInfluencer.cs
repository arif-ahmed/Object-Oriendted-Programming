namespace InfluencerManager
{
    public class BusinessInfluencer : Influencer
    {
        private const double engagementRate = 3.0;
        public BusinessInfluencer(string username, int followers ) 
            : base(username, followers, engagementRate)
        {
        }

        public override int CalculateCampaignPrice()
        {
            int result = 0;

            result = (int)Math.Floor(Followers * EngagementRate * 0.15);

            return result;
        }
    }
}
