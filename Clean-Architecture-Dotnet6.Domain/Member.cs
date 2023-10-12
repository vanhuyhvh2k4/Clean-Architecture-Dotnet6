
namespace Clean_Architecture_Dotnet6.Domain
{
    public class Member
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        // One to Many relationships
        public Guid RentalId { get; set; }

        public Rental Rental { get; set; }
    }
}
