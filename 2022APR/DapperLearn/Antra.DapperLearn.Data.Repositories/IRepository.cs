using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.DapperLearn.Data.Repositories
{
    public interface IRepository <T> where T : class
    {
        int Insert (T entity);
        int Update (T entity);
        int Delete (int Id);
        IEnumerable<T> GetAll ();
        T Find (int Id);
    }
}
