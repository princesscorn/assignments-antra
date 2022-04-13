using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// We already added the dependency of Data.Entity, so we can using it.
using Antra.DapperLearn.Data.Entity;
using System.Data;  // IDbConnection is in Data namespace
using Dapper;

namespace Antra.DapperLearn.Data.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {
        DapperDbContext DapperDb;
        public DepartmentRepository()
        {
            DapperDb = new DapperDbContext(); 
        }
        public int Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Department Find(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
            string command = "select Id DName Loc from Department";
            using (IDbConnection con = DapperDb.GetDbConnection())
            {
                return con.Query<Department>(command);
            }
        }

        public int Insert(Department entity)
        {
            // Id is primary key, will automatically has the increasing number
            string command = "Insert into Department values (@DName, @Loc)";
            using (IDbConnection con = DapperDb.GetDbConnection())
            {
                return con.Execute(command, entity);
            }
        }

        public int Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
