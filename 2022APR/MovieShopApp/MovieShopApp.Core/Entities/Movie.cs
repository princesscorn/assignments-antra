using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MovieShopApp.Core.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Title { get; set; }

        [MaxLength(1024)]
        [Column(TypeName = "varchar")]
        public string Overview { get; set; }

        [MaxLength(512)]
        [Column(TypeName = "varchar")]
        public string Tagline { get; set; }

        public Decimal Budget { get; set; }
        public Decimal Revenue { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string ImdbUrl { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string TmdbUrl { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string PosterUrl { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string BackdropUrl { get; set; }

        [MaxLength(2048)]
        [Column(TypeName = "varchar")]
        public string OriginalLanguage { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunTime { get; set; }
        public decimal? Price { get; set; }
        
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(64)]
        [Column(TypeName = "varchar")]
        public string? UpdatedBy { get; set; }
        [MaxLength(64)]
        [Column(TypeName = "varchar")]
        public string? CreatedBy { get; set; }
        

        // Movie can have multi casts
        public virtual IList<MovieCast>? MovieCasts { get; set; }
        public virtual IList<MovieGenre>? GenresOfMovie { get; set; }
        public virtual IList<Favorite>? FavoriteOfMovie { get; set; }
        public virtual IList<Review>? ReviewsOfMovie { get; set; }
        public virtual IList<Purchase>? PurchasesOfMovie { get; set; }
        public virtual IList<Trailer>? TrailersOfMovie { get; set; }
    }
}
