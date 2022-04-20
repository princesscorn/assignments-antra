using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieStoreApp.Core.Models
{
    public class GenreModel
    {
        public int Id { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
    }
}
