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
            return View(result);
        }
     }
}
