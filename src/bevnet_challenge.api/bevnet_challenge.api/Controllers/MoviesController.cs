using bevnet_challenge.Application.Common.Models;
using bevnet_challenge.Application.UseCases.Movies.Dtos;
using bevnet_challenge.Application.UseCases.Movies.GetMovies;
using bevnet_challenge.Application.UseCases.Movies.GetMoviesByTitle;
using Microsoft.AspNetCore.Mvc;

namespace bevnet_challenge.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ApiControllerBase
    {
        /// <summary>
        /// Returns 10 default movies
        /// </summary>
        /// <returns><see cref="PaginatedResponseDto{MovieDto}"/></returns>
        [HttpGet]
        [ProducesResponseType(typeof(PaginatedResponse<MovieDto>), 200)]
        public async Task<IActionResult> GetMovies([FromQuery] PaginatedRequest paginatedRequest)
        {
            var getMovies = new GetMoviesRequest(paginatedRequest);
            var movies = await Mediator.Send(getMovies);
            return Ok(movies);
        }

        /// <summary>
        /// Returns 10 movies by title
        /// </summary>
        /// <returns><see cref="PaginatedResponseDto{MovieDto}"/></returns>
        [HttpGet("{title}")]
        [ProducesResponseType(typeof(PaginatedResponse<MovieDto>), 200)]
        public async Task<IActionResult> GetMoviesByTitle(string title, [FromQuery] PaginatedRequest paginatedRequest)
        {
            var getMovies = new GetMoviesByTitleRequest(title, paginatedRequest);
            var movies = await Mediator.Send(getMovies);
            return Ok(movies);
        }
    }
}
