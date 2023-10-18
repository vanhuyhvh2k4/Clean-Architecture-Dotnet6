
using Clean_Architecture_Dotnet6.Domain;
using MediatR;

namespace Clean_Architecture_Dotnet6.Application.Queries
{
    public record GetMovieByIdQuery(Guid Id) : IRequest<Movie>;
}
