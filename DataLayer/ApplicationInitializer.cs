using System.Security.Cryptography.X509Certificates;
using DataLayer.DataSeeder;
using DataLayer.TableSets;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
   public class ApplicationInitializer:DbContext
    {
       

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName = .\\Movie.db;");
            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActors>()
                .HasKey(bc => new {bc.ActorId, bc.MovieId});
            modelBuilder.Entity<MovieActors>()
                .HasOne(c => c.Movie)
                .WithMany(d => d.MovieActors)
                .HasForeignKey(d => d.MovieId);

            modelBuilder.Entity<MovieActors>()
                .HasOne(b => b.Actors)
                .WithMany(d => d.MovieActors)
                .HasForeignKey(d => d.ActorId);
            Seeder.Seed(modelBuilder);
        }
       
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieActors> MovieActors { get; set; }

    }
}
