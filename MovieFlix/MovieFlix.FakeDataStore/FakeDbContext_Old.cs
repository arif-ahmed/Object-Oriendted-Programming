using MovieFlix.Models;

namespace MovieFlix.FakeDataStore
{
    public sealed class FakeDbContext_Old
    {
        private static readonly Lazy<FakeDbContext_Old> _instance = new Lazy<FakeDbContext_Old>(() => new FakeDbContext_Old());

        public static FakeDbContext_Old Instance => _instance.Value;

        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<User> Users { get; set; } = new List<User>();

        private FakeDbContext_Old()
        {
            // Initialize with default data if necessary
        }
    }
}
