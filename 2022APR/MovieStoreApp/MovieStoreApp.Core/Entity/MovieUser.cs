using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStoreApp.Core.Entity
{
    public class MovieUser : IdentityUser
    {
        public int Id { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        public ICollection<Role>? Roles { get; set; }
        public ICollection<Purchase>? Purchases { get; set; }
        public ICollection<Favorite>? Favorites { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
