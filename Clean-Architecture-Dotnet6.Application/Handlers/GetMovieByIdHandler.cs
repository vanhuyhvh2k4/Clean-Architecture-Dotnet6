using Clean_Architecture_Dotnet6.Application.Queries;
using Clean_Architecture_Dotnet6.Domain;
using MediatR;

namespace Clean_Architecture_Dotnet6.Application.Handlers
{
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQuery, Movie>
    {
        private readonly IMediator _mediator;

        public GetMovieByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Movie> Handle(GetMovieByIdQuery request, CancellationToken cancellation)
        {
            var movies = await _mediator.Send(new GetMovieListQuery());
            var movie = movies.FirstOrDefault(m => m.Id == request.Id);
            return movie;
        }
    }
}
