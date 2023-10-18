using Clean_Architecture_Dotnet6.Application.Queries;
using Clean_Architecture_Dotnet6.Domain;
using MediatR;

namespace Clean_Architecture_Dotnet6.Application.Handlers
{
    public class GetMovieListHandler : IRequestHandler<GetMovieListQuery, List<Movie>>
    {
        private readonly IMovieRepository _movieRepository;

        public GetMovieListHandler(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Task<List<Movie>> Handle(GetMovieListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_movieRepository.GetAllMovies());
        }
    }
}
