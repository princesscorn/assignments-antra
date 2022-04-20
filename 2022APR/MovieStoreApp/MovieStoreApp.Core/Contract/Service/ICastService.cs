using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.Core.Contract.Service
{
    public interface ICastServiceAsync
    {
        Task<int> AddCastAsync(CastModel model);
        Task<IEnumerable<CastModel>> GetAllCastsAsync();
        Task<CastModel> GetCastAsync(int id);
        Task<int> DeleteCastAsync(int id);
        Task<int> UpdateCastAsync(CastModel model);
    }
}
