using MovieShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Contracts.Repositories
{
    public interface ICastRepositoryAsync : IBaseRepositoryAsync<Cast>
    {
        //Task<IEnumerable<Cast>> GetTop10CastAsync();
    }
}
