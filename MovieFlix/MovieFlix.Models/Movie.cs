using MovieFlix.Models.Contracts;
using MovieFlix.Utilities;

namespace MovieFlix.Models
{
    public class Movie : IEntity, IMovie
    {
        private int _rating;
        private readonly List<int> userRating = new List<int>();

        public Movie(int id, string title, string description, Genre genre)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Genre = genre;
        }

        public int Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; private set; }
        public int Rating 
        { 
            get => _rating; 
            set 
            {
                if (value <= 0 || value > 10)
                    throw new ArgumentException(("Rating must be between 1 to 10"));

                userRating.Add(value);
                _rating = Convert.ToInt32(Math.Round(userRating.Average())); 
            } 
        }       
    }
}
