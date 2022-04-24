using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieShopApp.Core.Entities;

namespace MovieShopApp.Core.Entities
{
    public class Cast
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


        // Navigation Property defines the relationship between movie and casts
        // Lazy loading can cause unneeded extra database roundtrips to occur (the so-called N+1 problem),
        // and care should be taken to avoid this. 
        //public virtual ICollection<MovieCast>? MovieCasts { get; set; }

        // Cast can have multi movies
        public virtual IList<MovieCast>? MovieCasts { get; set; }
    }
}