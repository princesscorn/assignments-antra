using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieShopApp.Core.Entities
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        
        public int UsersId { get; set; }
        

        // try to define the relationship
        public virtual Movie? Movie { get; set; }
        public virtual Users? Users { get; set; }

        //public virtual Movie Movie { get; set; }
        //public virtual User User { get; set; }
        //public virtual IList<Movie> Movie { get; set; }
        //public virtual IList<User> User { get; set; }
    }
}
