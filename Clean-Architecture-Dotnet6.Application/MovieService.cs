
using Clean_Architecture_Dotnet6.Domain;

namespace Clean_Architecture_Dotnet6.Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();

            return movies;
        }
    }
}
