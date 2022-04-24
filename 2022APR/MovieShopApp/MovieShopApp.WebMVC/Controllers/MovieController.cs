using Microsoft.AspNetCore.Mvc;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Models;

namespace MovieShopApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        IMovieServiceAsync _movieServiceAsync;

        IMovieCastServiceAync _movieCastServiceAsync;

        public MovieController(IMovieServiceAsync movieServiceAsync, IMovieCastServiceAync movieCastServiceAsync)
        {
            _movieServiceAsync = movieServiceAsync;
            _movieCastServiceAsync = movieCastServiceAsync;
        }
        
        
        public async Task<IActionResult> Index(int pg = 1)
        {
            /*ViewBag.Title show on the Tab Name*/
            ViewBag.Title = "ViewBag Title in Index";

            //pagination
            //var result = await _movieServiceAsync.GetAllMoviesAsync();
            //return View(result);

            //List<MovieResponseModel> listMovieResponseModels = await _movieServiceAsync.GetAllMoviesAsync();
            var listMovieResponseModels = await _movieServiceAsync.GetAllMoviesAsync();
            const int pageSize = 30;
            if (pg < 1)
            {
                pg = 1;
            }

            int recordsCount = listMovieResponseModels.Count();
            var pager = new PaginationModel(recordsCount, pg, pageSize);
            int recordSkip = (pg - 1) * pageSize;
            var data = listMovieResponseModels.Skip(recordSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            return View(data);
            
        }

        public async Task<IActionResult> Detail(int movieId)
        {
            MovieResponseModel result = await _movieServiceAsync.GetMovieByIdAsync(movieId);
            //result.MovieCasts = await _movieServiceAsync.GetAllCastsByMovieIdAsync(movieId);
            result.MovieCasts = await _movieCastServiceAsync.GetAllCastsByMovieIdAsync(movieId);
            return View(result);
        }
    }
}
