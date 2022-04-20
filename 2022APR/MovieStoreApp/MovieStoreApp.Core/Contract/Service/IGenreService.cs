using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Core.Contract.Service
{
    public interface IGenreServiceAsync
    {
        Task<int> AddGenreAsync(GenreModel model);
        Task<IEnumerable<GenreModel>> GetAllGenresAsync();
        Task<GenreModel> GetGenreByIdAsync(int id);
        Task<int> DeleteGenreByIdAsync(int id);
        Task<int> UpdateGenreByIdAsync(GenreModel model);
    }
}
