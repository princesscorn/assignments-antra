using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>, ICastRepositoryAsync
    {
        public CastRepositoryAsync(MovieContext _db) : base(_db)
        {
        }
    }
}
