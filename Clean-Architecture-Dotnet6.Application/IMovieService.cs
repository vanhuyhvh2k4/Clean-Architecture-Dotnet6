
using Clean_Architecture_Dotnet6.Domain;

namespace Clean_Architecture_Dotnet6.Application
{
    // This is use case
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
    }
}
