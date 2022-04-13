using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;      // for IDbConnection
namespace Antra.DapperLearn.Data.Repositories
{
    internal class DapperDbContext
    {
        public IDbConnection GetDbConnection ()
        {
            // SqlConnection : DbConnection : IDbConnection, means SqlConnection is a IDbConnection
            // So here return type is fine.
            SqlConnection conn = new SqlConnection ("Data Source=.;Initial Catalog=April2022;Integrated Security=True");
            return conn;
        }
    }
}
