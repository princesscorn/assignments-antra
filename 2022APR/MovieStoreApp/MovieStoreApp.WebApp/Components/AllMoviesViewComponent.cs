using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;

namespace MovieStoreApp.WebApp.Components
{
    public class AllMoviesViewComponent : ViewComponent
    {
        IMovieServiceAsync movieService;

        public AllMoviesViewComponent(IMovieServiceAsync srv)
        {
            movieService = srv;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var result = await movieService.GetAllMoviesAsync();
            // "AllMovies" is the viewName, Views/Shared/Components/AllMovies/AllMovies.cshtml
            //return View("AllMovies", result);
            return View("AllMovies");
        }
    }
}
