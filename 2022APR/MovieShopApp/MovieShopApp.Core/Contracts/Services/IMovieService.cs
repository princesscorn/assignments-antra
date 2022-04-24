using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Contracts.Services
{
    public interface IMovieServiceAsync
    {
        Task<IEnumerable<MovieResponseModel>> GetAllMoviesAsync();
        Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync();
        Task<MovieResponseModel> GetMovieByIdAsync(int id);
        //Task<MovieCastModel> GetAllCastsByMovieIdAsync(int id)
        Task<IEnumerable<MovieResponseModel>> GetTop3LatestMoviesAsync();
        Task<IEnumerable<MovieResponseModel>> MoviesByGenreAsync(int movieId, int pagesize = 30, int pageNumber = 1);
    }
}
