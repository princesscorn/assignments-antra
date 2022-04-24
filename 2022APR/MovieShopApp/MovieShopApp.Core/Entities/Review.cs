using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieShopApp.Core.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MovieId { get; set; }

        [Required]
        public int UsersId { get; set; }
        public Decimal Rating { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string ReviewText { get; set; }
    }
}
