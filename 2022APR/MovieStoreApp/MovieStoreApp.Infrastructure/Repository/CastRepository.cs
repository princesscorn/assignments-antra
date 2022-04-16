using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository
{
    internal class CastRepositoryAsync : BaseRepositoryAsync<Cast>
    {
        public CastRepositoryAsync(MovieContext _db) : base(_db)
        {
        }
    }
}
