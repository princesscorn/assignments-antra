using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieStoreApp.Core.Entity
{
    public class MovieCast
    {
        [Key]
        public int MovieId { get; set; }
        public int CastId { get; set; }

        [MaxLength(450)]
        [Column(TypeName = "varchar")]
        public string Character { get; set; }
    }
}
