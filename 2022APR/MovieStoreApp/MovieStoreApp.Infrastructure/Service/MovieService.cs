using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Infrastructure.Service
{
    public class MovieServiceAsync : IMovieServiceAsync
    {
        IMovieRepositoryAsync movieRepositoryAsync;
        public MovieServiceAsync(IMovieRepositoryAsync _m)
        {
            movieRepositoryAsync = _m;
        }

        public async Task<MovieResponseModel> GetByIdAsync(int id)
        {
            MovieResponseModel responseModel = new MovieResponseModel();
            var movie = await movieRepositoryAsync.GetAsync(id);
            if (movie != null)
            {
                responseModel.Id = movie.Id;
                responseModel.Overview = movie.Overview;
                responseModel.ImdbUrl = movie.ImdbUrl;
                responseModel.OriginalLanguage = movie.OriginalLanguage;
                responseModel.Tagline = movie.Tagline;
                responseModel.PosterUrl = movie.PosterUrl;
                responseModel.Price = movie.Price;
                responseModel.ReleaseDate = movie.ReleaseDate;
                responseModel.Revenue = movie.Revenue;
                responseModel.RunTime = movie.RunTime;
                responseModel.TmdbUrl = movie.TmdbUrl;
                responseModel.Title = movie.Title;
                responseModel.Budget = movie.Budget;
            }
            return responseModel;
        }
        public async Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync()
        {
            var result = await movieRepositoryAsync.GetTop10RevenueMoviesAsync();
            List<MovieResponseModel> listMovieResponse = new List<MovieResponseModel>();
            foreach(var movie in result)
            {
                MovieResponseModel responseModel = new MovieResponseModel();
                responseModel.Id = movie.Id;
                responseModel.Overview = movie.Overview;
                responseModel.ImdbUrl = movie.ImdbUrl;
                responseModel.OriginalLanguage = movie.OriginalLanguage;
                responseModel.Tagline = movie.Tagline;
                responseModel.PosterUrl = movie.PosterUrl;
                responseModel.Price = movie.Price;
                responseModel.ReleaseDate = movie.ReleaseDate;
                responseModel.Revenue = movie.Revenue;
                responseModel.RunTime = movie.RunTime;
                responseModel.TmdbUrl = movie.TmdbUrl;
                responseModel.Title = movie.Title;
                responseModel.Budget = movie.Budget;
                listMovieResponse.Add(responseModel);
            }
            return listMovieResponse;
        }
    }
}
