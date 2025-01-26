
using MovieFlix.Models;

namespace MovieFlix.FakeDataStore
{
    public class FakeDbContext
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<User> Users { get; set; } = new List<User>();
    }
}
