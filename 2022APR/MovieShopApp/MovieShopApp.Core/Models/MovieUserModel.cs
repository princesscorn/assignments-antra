using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopApp.Core.Models
{
    public class MovieUserModel
    {
        [Required]
        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        [EmailAddress]
        public string EmailId { get; set; }

        [Required]
        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
