using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Contracts.Services;
using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Infrastructure.Services
{
    public class MovieServiceAsync : IMovieServiceAsync
    {
        private readonly IMovieRepositoryAsync _movieRepositoryAsync;
        public MovieServiceAsync(IMovieRepositoryAsync movieRepositoryAsync)
        {
            _movieRepositoryAsync = movieRepositoryAsync;
        }

        public async Task<IEnumerable<MovieResponseModel>> GetAllMoviesAsync()
        {
            var result = await _movieRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                List<MovieResponseModel> list = new List<MovieResponseModel>();
                foreach (var item in result)
                {
                    MovieResponseModel model = new MovieResponseModel();
                    model.Id = item.Id;
                    model.Title = item.Title;
                    model.TmdbUrl = item.TmdbUrl;
                    model.PosterUrl = item.PosterUrl;
                    if (item.GenresOfMovie != null) 
                    { 
                        List< MovieGenreModel> genreList = new List<MovieGenreModel>();
                        foreach (var g in item.GenresOfMovie)
                        {
                            MovieGenreModel movieGenreModel = new MovieGenreModel();
                            {
                                movieGenreModel.Genre = g.Genre;
                            }
                            genreList.Add(movieGenreModel);
                        }
                    }
                    model.GenresOfMovie = item.GenresOfMovie;
                    list.Add(model);
                }
                return list;
            }
            return null; 
        }

        public async Task<MovieResponseModel> GetMovieByIdAsync(int id)
        {
            var movie = await _movieRepositoryAsync.GetByIdAsync(id);
            MovieResponseModel responseModel = new MovieResponseModel();
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
            
            //model.GenresOfMovie = result.GenresOfMovie.ToList();
            if ((movie != null) && (movie.GenresOfMovie != null) )
            { 
                List< MovieGenreModel> genreList = new List<MovieGenreModel>();
                foreach (var g in movie.GenresOfMovie)
                {
                    MovieGenreModel movieGenreModel = new MovieGenreModel();
                    {
                        movieGenreModel.Genre.Id = g.Genre.Id;
                        movieGenreModel.Genre.Name = g.Genre.Name;
                    }
                    genreList.Add(movieGenreModel);
                }
                responseModel.GenresOfMovie = movie.GenresOfMovie;
            }
            
            return responseModel;
        }

        /*public async Task<MovieCastModel> GetAllCastsByMovieIdAsync(int id)
        {
            var movie = await _movieRepositoryAsync.GetByIdAsync(id);
            MovieCastModel movieCastModel = new MovieCastModel();
            {
                movieCastModel.CastId = movie.Id;
                movieCastModel
            }
            
            throw new NotImplementedException();
        }*/

        public Task<IEnumerable<MovieResponseModel>> GetTop10RevenueMoviesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieResponseModel>> GetTop3LatestMoviesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MovieResponseModel>> MoviesByGenreAsync(int movieId, int pagesize = 30, int pageNumber = 1)
        {
            throw new NotImplementedException();
        }
    }
}
