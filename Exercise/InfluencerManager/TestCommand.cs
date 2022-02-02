using Infrastructure.Contracts;

namespace InfluencerManager
{
    public class TestCommand : ICommand
    {
        public string Name => GetType().Name;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
