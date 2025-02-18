using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interface;
using MovieStore.Models.DTO;
using MovieStore.Models.Requests;

namespace MovieStoreC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public MoviesController(
            IMovieService movieService,
            IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _movieService.GetAll();

            if (result != null && result.Count > 0)
            {
                return Ok(result);
            }

            return NotFound();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("GetById")]
        public IActionResult GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest($"Wrong ID:{id}");
            }

            var result = _movieService.GetById(id);

            if (result == null)
            {
                return NotFound($"Movie with ID:{id} not found");
            }

            return Ok(result);
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody]AddMovieRequest movie)
        {
            var movieDto = _mapper.Map<Movie>(movie);

            _movieService.Add(movieDto);

            return Ok();
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            //return _movieService.GetById(id);
        }
    }
}
