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
    public class MovieCastServiceAsync : IMovieCastServiceAsync
    {
        IMovieCastRepositoryAsync movieCastRepositoryAsync;
        public MovieCastServiceAsync(IMovieCastRepositoryAsync _movie)
        {
            movieCastRepositoryAsync = _movie;
        }

        public async Task<IEnumerable<MovieCastModel>> GetAllByMovieIdAsync(int movieId)
        {
            var result = await movieCastRepositoryAsync.GetAllByMovieIdAsync(movieId);
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
