using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieStoreApp.Core.Entity
{
    public class MovieCrew
    {
        [Key]
        public int MovieId { get; set; }
        public int CrewId { get; set;}

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string Department { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]

        public string Job { get; set; }
    }
}
