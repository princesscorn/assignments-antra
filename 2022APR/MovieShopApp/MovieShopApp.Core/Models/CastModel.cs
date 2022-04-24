using MovieShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Models
{
    public class CastModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string? Name { get; set; }
        public int? Gender { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string? TmdbUrl { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string? ProfilePath { get; set; }

        // Cast can have multi movies
        public virtual IList<MovieCast>? MovieCasts { get; set; }
    }
}
