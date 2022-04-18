using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;

namespace MovieStoreApp.WebApp.Components
{
    public class TopMovieViewComponent : ViewComponent
    {
        IMovieServiceAsync movieService;

        public TopMovieViewComponent(IMovieServiceAsync srv)
        {
            movieService = srv;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await movieService.GetTop10RevenueMoviesAsync();
            // "Top10RevenueMovies" is the viewName, Views/Shared/Components/LatestMovie/Top10RevenueMovies.cshtml
            return View("Top10RevenueMovies", result);
        }
     }
}
