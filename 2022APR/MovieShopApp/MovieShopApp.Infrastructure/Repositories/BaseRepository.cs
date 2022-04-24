using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieShopApp.Core.Contracts.Repositories;
using MovieShopApp.Infrastructure.Datas;

namespace MovieShopApp.Infrastructure.Repositories
{
    public class BaseRepositoryAsync<T> : IBaseRepositoryAsync<T> where T : class
    {
        private readonly MovieDbContext _db;
        public BaseRepositoryAsync(MovieDbContext db)
        {
            _db = db;
        }

        public async Task<int> DeleteAsync(int id)
        {
            // == _db.Set<T>().Where(x=>x.Id==id).FirstOrDefault();
            var entity = await _db.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _db.Set<T>().Remove(entity);
                _db.SaveChanges();
                return 1;
            }
            else 
            { 
                return 0; 
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public IEnumerable<T> GetByConditions(Expression<Func<T, bool>> filter)
        {
            return _db.Set<T>().Where(filter);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            _db.SaveChangesAsync();       // commit, but my program cannot do anything else until the commit finishes
            return 1;
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _db.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChangesAsync();
            return 1;
        }
    }
}
