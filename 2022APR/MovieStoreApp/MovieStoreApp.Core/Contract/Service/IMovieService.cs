using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Core.Contract.Service
{
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync();
        Task<MovieResponseModel> GetByIdAsync(int id);
        Task<IEnumerable<MovieResponseModel>> GetTop3LatestMoviesAsync();
    }
}
