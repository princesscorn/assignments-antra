using Microsoft.EntityFrameworkCore;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Entities;
using MovieShopApp.Infrastructure.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Infrastructure.Repositories
{
    public class MovieCastRepositoryAsync : BaseRepositoryAsync<MovieCast>, IMovieCastRepositoryAsync
    {
        private readonly MovieDbContext _dbContext;
        public MovieCastRepositoryAsync(MovieDbContext db) : base(db)
        {
            _dbContext = db;
        }

        public async Task<IEnumerable<MovieCast>> GetAllCastsByMovieIdAsync(int movieId)
        {
            return await _dbContext.MovieCast.Include("Cast").Where(x => x.MovieId == movieId).ToListAsync();
        }
    }
}
