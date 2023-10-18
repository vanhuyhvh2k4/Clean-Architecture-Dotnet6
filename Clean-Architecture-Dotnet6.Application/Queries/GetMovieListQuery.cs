using Clean_Architecture_Dotnet6.Domain;
using MediatR;

namespace Clean_Architecture_Dotnet6.Application.Queries
{
    public record GetMovieListQuery() : IRequest<List<Movie>>;
}
