using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.DapperLearn.Data.Entity
{
    public class Department
    {
        // ID, DName, Loc
        // Columns -> properities
        public int Id { get; set; }
        public string DName { get; set; }
        public string Loc { get; set; }
    }
}
