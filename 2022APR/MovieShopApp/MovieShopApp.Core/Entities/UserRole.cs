using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieShopApp.Core.Entities
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int RoleId { get; set; }
        public virtual Users? Users { get; set; }
        public virtual Role? Role { get; set; }
    }
}
