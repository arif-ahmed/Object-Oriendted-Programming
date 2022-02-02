namespace InfluencerManager
{
    public class FashionInfluencer : Influencer
    {
        private const double engagementRate = 4.0;
        public FashionInfluencer(string username, int followers) 
            : base(username, followers, engagementRate)
        {
        }

        public override int CalculateCampaignPrice()
        {
            int result = 0;

            result = (int)Math.Floor(Followers * EngagementRate * 0.1);

            return result;
        }
    }
}
