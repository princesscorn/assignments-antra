using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.WebApp.Models;
using MovieStoreApp.WebApp.Repository;

namespace MovieStoreApp.WebApp.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movieRepository;
        public MovieController()
        {
            movieRepository = new MovieRepository();
        }
        public IActionResult Index()
        {
            ViewBag.Title = "All Movies";
            IEnumerable<MovieModel> lstMovies = movieRepository.GetAll();
            return View(lstMovies);
        }

        /*For the Show Details Button*/

        public IActionResult Detail(int movieId)
        {
            MovieModel movieModel = movieRepository.GetById(movieId);
            return View(movieModel);
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
