using MovieShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Contracts.Services
{
    public interface ICastServiceAsync
    {
        //Task<IEnumerable<CastModel>> GetCastsByMovieIdAsync(int id);
        Task<IEnumerable<CastModel>> GetAllCastsAsync();
        Task<CastModel> GetCastByCastIdAsync(int id);

        Task<int> AddCastAsync(CastModel model);
        Task<int> DeleteCastAsync(int id);
        Task<int> UpdateCastAsync(CastModel model);
    }
}
