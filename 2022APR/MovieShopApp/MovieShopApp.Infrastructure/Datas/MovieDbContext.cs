using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieShopApp.Core.Entities;

namespace MovieShopApp.Infrastructure.Datas
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> option) : base(option)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCast>().HasKey(mc => new { mc.MovieId, mc.CastId });
            modelBuilder.Entity<MovieCast>().HasOne(m => m.Movie).WithMany(mc => mc.MovieCasts).HasForeignKey(m=>m.MovieId);
            modelBuilder.Entity<MovieCast>().HasOne(c => c.Cast).WithMany(mc => mc.MovieCasts).HasForeignKey(c => c.CastId);
            
            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.UsersId, ur.RoleId });
            modelBuilder.Entity<UserRole>().HasOne(u => u.Users).WithMany(ur => ur.UserRoles).HasForeignKey(u => u.UsersId);
            modelBuilder.Entity<UserRole>().HasOne(r => r.Role).WithMany(ur => ur.UserRoles).HasForeignKey(r => r.RoleId);

            modelBuilder.Entity<MovieGenre>().HasKey(mg => new { mg.MovieId, mg.GenreId });
            modelBuilder.Entity<MovieGenre>().HasOne(m => m.Movie).WithMany(mg => mg.GenresOfMovie).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<MovieGenre>().HasOne(g => g.Genre).WithMany(mg => mg.MoviesOfGenre).HasForeignKey(g => g.GenreId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Cast> Cast { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieCast> MovieCast { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Trailer> Trailer { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}
