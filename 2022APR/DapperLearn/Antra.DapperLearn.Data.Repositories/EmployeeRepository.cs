using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We already added the dependency of Data.Entity, so we can using it.
using Antra.DapperLearn.Data.Entity;

namespace Antra.DapperLearn.Data.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Employee Find(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
