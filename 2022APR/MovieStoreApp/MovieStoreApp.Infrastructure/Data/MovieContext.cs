using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreApp.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MovieStoreApp.Infrastructure.Data
{
    public class MovieContext : IdentityDbContext<MovieUser>
    {
        public MovieContext(DbContextOptions<MovieContext> option) : base(option)
        {

        }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieCast> MovieCast { get; set;}
        public DbSet<MovieCrew> MovieCrew { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set;}
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<MovieUser> MovieUser { get; set; }

    }
}
