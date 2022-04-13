using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.DapperLearn.Data.Entity
{
    public class Employee
    {
        // Id, FirstName, LastName, Salary, DeptId
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
    }
}
