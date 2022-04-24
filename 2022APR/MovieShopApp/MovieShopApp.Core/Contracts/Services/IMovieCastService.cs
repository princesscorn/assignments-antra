using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Contracts.Services
{
    public interface IMovieCastServiceAync
    {
        Task<IEnumerable<MovieCastModel>> GetAllCastsByMovieIdAsync(int movieId);
    }
}
