using Clean_Architecture_Dotnet6.Application;
using Clean_Architecture_Dotnet6.Application.Commands;
using Clean_Architecture_Dotnet6.Application.Queries;
using Clean_Architecture_Dotnet6.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean_Architecture_Dotnet6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;
        private readonly IMediator _mediator;

        public MovieController(IMovieService service, IMediator mediator)
        {
            _service = service;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Movie>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }

        [HttpGet("{id}")]
        public async Task<Movie> Get(Guid Id)
        {
            return await _mediator.Send(new GetMovieByIdQuery(Id));
        }

        [HttpPost]
        public async Task<Movie> PostMovie(Movie movie)
        {
            return await _mediator.Send(new AddMovieCommand(movie));
        }
    }
}
