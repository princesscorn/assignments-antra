using MovieShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Models
{
    public class MovieGenreModel
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public virtual Movie? Movie { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}
