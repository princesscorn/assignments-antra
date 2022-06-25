using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Models;

namespace MovieShopApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServiceAsync _movieServiceAsync;
        IMovieCastServiceAync _movieCastServiceAsync;

        public MovieController(IMovieServiceAsync movieServiceAsync, IMovieCastServiceAync movieCastServiceAsync)
        {
            _movieServiceAsync = movieServiceAsync;      
            _movieCastServiceAsync = movieCastServiceAsync;
            
        }

        [HttpGet]
        //[Route("id")]
        [Route("{id:int}")]
        public async Task<IActionResult> Detail(int id)
        {
            MovieResponseModel result = await _movieServiceAsync.GetMovieByIdAsync(id);
            //result.MovieCasts = await _movieServiceAsync.GetAllCastsByMovieIdAsync(movieId);
            result.MovieCasts = await _movieCastServiceAsync.GetAllCastsByMovieIdAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _movieServiceAsync.GetAllMoviesAsync();
            return Ok(result);
        }
    }
}
