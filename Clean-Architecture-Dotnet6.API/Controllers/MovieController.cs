using Clean_Architecture_Dotnet6.Application;
using Clean_Architecture_Dotnet6.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Clean_Architecture_Dotnet6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var moviesFromService = _service.GetAllMovies();
            return Ok(moviesFromService);
        }
    }
}
