using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieStoreApp.Core.Models
{
    public class CastModel
    {
        public int Id { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        public int Gender { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string TmdbUrl { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string ProfilePath { get; set; }

        public virtual ICollection<MovieCastModel> MovieCasts { get; set; }
    }
}
