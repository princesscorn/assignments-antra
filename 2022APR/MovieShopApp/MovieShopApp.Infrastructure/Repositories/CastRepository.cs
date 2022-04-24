using MovieShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Infrastructure.Datas;
using Microsoft.EntityFrameworkCore;

namespace MovieShopApp.Infrastructure.Repositories
{
    public class CastRepositoryAsync : BaseRepositoryAsync<Cast>, ICastRepositoryAsync
    {
        private readonly MovieDbContext _db;
        public CastRepositoryAsync(MovieDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        /*public Task<IEnumerable<Cast>> GetTop10CastAsync()
        {
            throw new NotImplementedException();
        }*/
    }
}
