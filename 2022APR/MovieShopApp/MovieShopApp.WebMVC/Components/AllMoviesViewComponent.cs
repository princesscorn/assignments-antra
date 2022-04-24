using Microsoft.AspNetCore.Mvc;
using MovieShopApp.Core.Contracts.Services;

namespace MovieShopApp.WebMVC.Components
{
    public class AllMoviesViewComponent : ViewComponent
    {
        private readonly IMovieServiceAsync _movieServiceAsync;
        public AllMoviesViewComponent(IMovieServiceAsync movieServiceAsync)
        {
            _movieServiceAsync = movieServiceAsync;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _movieServiceAsync.GetAllMoviesAsync();
            return View("ListAllMovies", result);
        }
    }
}
