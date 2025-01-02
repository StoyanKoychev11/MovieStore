using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.Requests;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesBlController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly ILogger<MoviesController> _logger;

        public MoviesBlController(
            IMovieService movieService,
            ILogger<MoviesController> logger)
        {
            _movieService = movieService;
            _logger = logger;
        }

        [HttpPost("TestFluentValid")]
        public IActionResult TestFluentValid([FromBody] TestRequest movieRequest)
        {
            //if (movieRequest == null) return BadRequest();

            //if (movieRequest.Id <= 0) return BadRequest();

            //if (movieRequest.Title == null) return BadRequest();

            //if (string.IsNullOrWhiteSpace(movieRequest.Title)) return BadRequest(); 

            //if (movieRequest.Title.Length <= 1 || movieRequest.Title.Length > 50) return BadRequest();

            return Ok();
        }

        [HttpGet("GetAll")]
        public IEnumerable<Movie> GetAll()
        {
            try
            {
                //code
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Error in GetAll {e.Message}-{e.StackTrace}");
            }
            return _movieService.GetMovies();
        }
    }

    public class TestRequest
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
