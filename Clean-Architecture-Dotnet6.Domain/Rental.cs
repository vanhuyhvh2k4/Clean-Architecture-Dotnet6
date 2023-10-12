namespace Clean_Architecture_Dotnet6.Domain
{
    public class Rental
    {
        public Guid Id { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime RentalExpiry { get; set; }

        public decimal TotalCost { get; set; }

        // One to Many relationships
        public ICollection<Member> Members { get; set; }

        public IList<MovieRental> MovieRentals { get; set; }
    }
}