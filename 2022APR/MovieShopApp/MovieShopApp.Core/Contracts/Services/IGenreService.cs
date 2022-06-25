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
        Task<GenreModel> GetGenreByGenreIdAsync(int id);
        Task<int> AddGenreAsync(GenreModel model);
        //Task<int> InsertGenreAsync(GenreModel model);
        Task<int> DeleteGenreByIdAsync(int id);
        Task<int> UpdateGenreAsync(GenreModel model);
    }
}
