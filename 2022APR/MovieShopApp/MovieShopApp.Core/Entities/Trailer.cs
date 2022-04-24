using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieShopApp.Core.Entities
{
    public class Trailer
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string TrailerUrl { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
    }
}
