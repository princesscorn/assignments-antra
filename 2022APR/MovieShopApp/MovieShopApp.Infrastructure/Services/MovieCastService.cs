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
    public class MovieCastServiceAsync : IMovieCastServiceAync
    {
        IMovieCastRepositoryAsync _movieCastRepositoryAsync;
        public MovieCastServiceAsync(IMovieCastRepositoryAsync _movie)
        {
            _movieCastRepositoryAsync = _movie;
        }

        public async Task<IEnumerable<MovieCastModel>> GetAllCastsByMovieIdAsync(int movieId)
        {
            var result = await _movieCastRepositoryAsync.GetAllCastsByMovieIdAsync(movieId);
            List<MovieCastModel> listModel = new List<MovieCastModel>();
            foreach (var item in result)
            {
                MovieCastModel model = new MovieCastModel();
                model.Id = item.Id;
                model.CastId = item.CastId;
                model.Cast = new CastModel()
                {
                    Id = item.Cast.Id,
                    Gender = item.Cast.Gender,
                    Name = item.Cast.Name,
                    ProfilePath = item.Cast.ProfilePath,
                    TmdbUrl = item.Cast.TmdbUrl
                };
                listModel.Add(model);
            }
            return listModel;
        }
    }
}
