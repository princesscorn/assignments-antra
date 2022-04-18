using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;

namespace MovieStoreApp.WebApp.Components
{
    public class LatestMovieViewComponent : ViewComponent
    {
        IMovieServiceAsync movieService;
        public LatestMovieViewComponent(IMovieServiceAsync ser)
        {
            movieService = ser;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await movieService.GetTop3LatestMoviesAsync();
            // "Latest3Movies" is the viewName, Views/Shared/Components/LatestMovie/Latest3Movies.cshtml
            return View("Latest3Movies", result);
        }
    }
}
