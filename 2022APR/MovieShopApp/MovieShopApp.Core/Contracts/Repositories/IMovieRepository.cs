using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopApp.Core.Entities;
using MovieShopApp.Core.Models;

namespace MovieShopApp.Core.Contracts.Repositories
{
    public interface IMovieRepositoryAsync : IBaseRepositoryAsync<Movie>
    {
        Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync();
        Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync();
        Task<List<Movie>> GetTop30RatedMoviesAsync();
        Task<decimal> GetMovieRatingByIdAsync(int id);
        Task<List<Movie>> GetMoviesByGenreAsync(int id);

        //PaginationModel<Movie> GetMoviesByTitleAsync(int pageSize = 30, int page = 1, string title = "");
    }
}
