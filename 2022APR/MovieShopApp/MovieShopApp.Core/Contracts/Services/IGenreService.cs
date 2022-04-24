using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Contracts.Services
{
    public interface IGenreServiceAsync
    {
        Task<IEnumerable<GenreModel>> GetAllGenresAsync();
        Task<int> InsertGenreAsync(GenreModel model);
        Task<int> DeleteGenreAsync(int id);
        Task<int> UpdateGenreAsync(GenreModel model);
    }
}
