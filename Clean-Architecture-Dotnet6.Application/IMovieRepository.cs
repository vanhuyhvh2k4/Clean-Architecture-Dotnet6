using Clean_Architecture_Dotnet6.Domain;

namespace Clean_Architecture_Dotnet6.Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();

        Movie CreateMovie(Movie movie);
    }
}
