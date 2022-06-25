using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Core.Entities;
using MovieShopApp.Infrastructure.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Infrastructure.Repositories
{
    public class GenreRepositoryAsync : BaseRepositoryAsync<Genre>, IGenreRepositoryAsync
    {
        private readonly MovieDbContext _db;
        public GenreRepositoryAsync(MovieDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }
    }
}
