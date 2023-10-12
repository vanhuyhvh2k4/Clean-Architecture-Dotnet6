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
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);
            _movieDbContext.SaveChanges();

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }
    }
}
