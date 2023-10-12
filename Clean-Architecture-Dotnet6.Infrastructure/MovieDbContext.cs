
using Clean_Architecture_Dotnet6.Domain;
using Microsoft.EntityFrameworkCore;

namespace Clean_Architecture_Dotnet6.Infrastructure
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many (Member and Rental)
            modelBuilder.Entity<Member>()
                .HasOne<Rental>(s => s.Rental)
                .WithMany(r => r.Members)
                .HasForeignKey(s => s.RentalId);

            // Many to Many (Rental and Movie)
            modelBuilder.Entity<MovieRental>()
                .HasKey(g => new { g.RentalId, g.MovieId });


            modelBuilder.Entity<Rental>()
                        .Property(p => p.TotalCost)
                        .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Movie>()
                        .Property(p => p.RentalDuration)
                        .HasColumnType("decimal(18, 2)");
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}
