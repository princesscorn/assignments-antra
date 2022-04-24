using System;
using System.Collections.Generic;
using MovieShopApp.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Models
{
    public class MovieCastModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int CastId { get; set; }

        [Required]
        [MaxLength(450)]
        [Column(TypeName = "varchar")]
        public string Character { get; set; }

        //public virtual Movie? Movie { get; set; }  //lazy loading
        //public virtual Cast? Cast { get; set; }    //virtual properties help in lazy loading
        public virtual MovieResponseModel? Movie { get; set; }
        public virtual CastModel? Cast { get; set; }
    }
}
