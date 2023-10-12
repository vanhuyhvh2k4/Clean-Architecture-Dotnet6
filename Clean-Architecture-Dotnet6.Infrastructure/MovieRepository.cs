using Clean_Architecture_Dotnet6.Application;
using Clean_Architecture_Dotnet6.Domain;

namespace Clean_Architecture_Dotnet6.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie
            {
                Id = Guid.NewGuid(),
                Name = "Foo",
                Cost = 2,
            },
            new Movie
            {
                Id = Guid.NewGuid(),
                Name = "Faa",
                Cost = 1,
            },
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
