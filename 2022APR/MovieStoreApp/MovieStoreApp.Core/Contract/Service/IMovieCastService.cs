using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Core.Contract.Service
{
    public interface IMovieCastServiceAsync
    {
        Task<IEnumerable<MovieCastModel>> GetAllByMovieIdAsync(int movieId);
    }
}
