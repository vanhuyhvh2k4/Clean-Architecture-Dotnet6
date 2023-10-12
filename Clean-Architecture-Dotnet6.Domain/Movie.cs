
namespace Clean_Architecture_Dotnet6.Domain
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Cost { get; set; }

        public int RentalDuration { get; set; }

        // Many to Many relationships
        public IList<MovieRental> MovieRentals { get; set; }
    }
}
