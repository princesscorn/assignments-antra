using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Contracts.Repositories
{
    public interface IBaseRepositoryAsync<T> where T : class
    {
        public Task<int> DeleteAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public IEnumerable<T> GetByConditions(Expression<Func<T, bool>> filter);
        public Task<T> GetByIdAsync(int id);
        public Task<int> InsertAsync(T entity);
        public Task<int> UpdateAsync(T entity);
    }
}
