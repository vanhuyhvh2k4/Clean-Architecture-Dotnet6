using Clean_Architecture_Dotnet6.Application.Commands;
using Clean_Architecture_Dotnet6.Domain;
using MediatR;

namespace Clean_Architecture_Dotnet6.Application.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, Movie>
    {
        private readonly IMovieRepository _movieRepository;

        public AddMovieHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Task<Movie> Handle(AddMovieCommand request, CancellationToken cancellation)
        {
            return Task.FromResult(_movieRepository.CreateMovie(request.movie));
        }
    }
}
