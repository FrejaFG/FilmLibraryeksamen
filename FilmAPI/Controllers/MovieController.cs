using FilmAPI.managers;
using FilmLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace FilmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // create manager
        private readonly MovieManager _mgr = new MovieManager();


        // GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            List<Movie> liste = _mgr.GetAll();
            return (liste.Count == 0) ? NoContent() : Ok(liste);

        }

        // GET - By Id
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_mgr.GetById(id));
            }

            catch(KeyNotFoundException knf)
            {
                return NotFound(knf.Message);
            }
        }

        // POST - Movie
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Movie mov)
        {
            try
            {
                Movie postedMovie = _mgr.PostMovie(mov);
                return Created("api/Movie/" + postedMovie.Id, postedMovie);
            }
            catch (ArgumentException argex)
            {
                return BadRequest(argex.Message);
            }

        }


    }
}
