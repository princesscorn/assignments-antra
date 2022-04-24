using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopApp.Core.Entities;

namespace MovieShopApp.Core.Contracts.Repositories
{
    public interface IMovieCastRepositoryAsync : IBaseRepositoryAsync<MovieCast>
    {
        Task<IEnumerable<MovieCast>> GetAllCastsByMovieIdAsync(int movieId);
    }
}
