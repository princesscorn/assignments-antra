using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieShopApp.Core.Entities
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int PurchaseNumber { get; set; }
        public Decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }

        public virtual Movie? Movie { get; set; }
        public virtual Users? Users { get; set; }
    }
}
