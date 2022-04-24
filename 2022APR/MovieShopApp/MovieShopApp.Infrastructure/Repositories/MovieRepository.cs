using Microsoft.EntityFrameworkCore;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Entities;
using MovieShopApp.Core.Models;
using MovieShopApp.Infrastructure.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Infrastructure.Repositories
{
    public class MovieRepositoryAsync : BaseRepositoryAsync<Movie>, IMovieRepositoryAsync
    {
        private readonly MovieDbContext _dbContext;
        public MovieRepositoryAsync(MovieDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync()
        {
            return await _dbContext.Movie.OrderByDescending(x => x.Revenue).Take(10).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync()
        {
            return await _dbContext.Movie.OrderByDescending(x => x.ReleaseDate).Take(3).ToListAsync();
        }

        Task<decimal> IMovieRepositoryAsync.GetMovieRatingByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Movie>> IMovieRepositoryAsync.GetMoviesByGenreAsync(int id)
        {
            throw new NotImplementedException();
        }

        /*PaginationModel<Movie> IMovieRepositoryAsync.GetMoviesByTitleAsync(int pageSize, int page, string title)
        {
            throw new NotImplementedException();
        }*/

        Task<List<Movie>> IMovieRepositoryAsync.GetTop30RatedMoviesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
