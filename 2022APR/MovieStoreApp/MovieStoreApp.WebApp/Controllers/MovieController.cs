using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.WebApp.Models;
//using MovieStoreApp.WebApp.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
//using MovieStoreApp.Core.Models;
//using MovieStoreApp.Infrastructure.Service;

namespace MovieStoreApp.WebApp.Controllers
{
    public class MovieController : Controller
    {
        IMovieServiceAsync mServiceAsync;
        IMovieCastServiceAsync mcServiceAsync;
        public MovieController(IMovieServiceAsync realMovieServiceAsync, IMovieCastServiceAsync mcService)
        {
            mServiceAsync = realMovieServiceAsync;
            mcServiceAsync = mcService;

        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "All Movies";
            //IEnumerable<MovieModel> lstMovies = movieRepository.GetAll();
            // Core.Models/MovieResponseModel,
            // means, here, we call IEnumerable<MovieResponseModel> GetTop10RevenueMovie(), which is implemented in Service
            var result = await mServiceAsync.GetTop10RevenueMoviesAsync();
            //return View(lstMovies);
            return View(result);
        }

        /*For the Show Details Button*/

        public async Task<IActionResult> Detail(int movieId)
        {
            //MovieModel movieModel = movieServiceAsync.GetByIdAsync(movieId);
            MovieResponseModel result = await mServiceAsync.GetByIdAsync(movieId);
            result.MovieCasts = await mcServiceAsync.GetAllByMovieIdAsync(movieId);
            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieModel movieModel)
        {
            // call the repository insert method to save the movie in database
            if (movieModel.Title != null)
            {
                return RedirectToAction("Index");
            }
            return View(movieModel);
        }
    }
}
