
using Clean_Architecture_Dotnet6.Domain;
using MediatR;

namespace Clean_Architecture_Dotnet6.Application.Commands
{
    public record AddMovieCommand(Movie movie) : IRequest<Movie>;
}
