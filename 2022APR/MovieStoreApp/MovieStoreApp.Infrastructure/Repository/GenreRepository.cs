using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;
using MovieStoreApp.Infrastructure.Data;

namespace MovieStoreApp.Infrastructure.Repository
{
    internal class GenreRepositoryAsync : BaseRepositoryAsync<Genre>
    {
        public GenreRepositoryAsync(MovieContext _db) : base(_db)
        {
        }
    }
}
