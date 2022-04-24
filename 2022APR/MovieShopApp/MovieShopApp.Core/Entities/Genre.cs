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
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        // one movie can belong to multi Genre
        public virtual IList<MovieGenre>? MoviesOfGenre { get; set; }
    }
}