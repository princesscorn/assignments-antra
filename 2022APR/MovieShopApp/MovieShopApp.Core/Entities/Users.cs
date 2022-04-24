using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieShopApp.Core.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [MaxLength(128)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        [MaxLength(1024)]
        [Column(TypeName = "varchar")]
        public string HashedPassword { get; set; }

        [MaxLength(1024)]
        [Column(TypeName = "varchar")]
        public string Salt { get; set; }

        [MaxLength(16)]
        [Column(TypeName = "varchar")]
        public string PhoneNumber { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDate { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public bool? IsLocked { get; set; }
        public int? AccessFailedCount { get; set; }

        public virtual IList<Review>? ReviewFromUser { get; set; }
        public virtual IList<Favorite>? UserFavorite { get; set; }
        public virtual IList<Purchase>? UserPurchases { get; set; }
        public virtual IList<UserRole>? UserRoles { get; set; }

    }
}
