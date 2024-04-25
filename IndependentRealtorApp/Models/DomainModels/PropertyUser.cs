namespace IndependentRealtorApp.Models.DomainModels
{
    public class PropertyUser
    {

        // the table keeps track of which user like what properties
        public int PropertyId { get; set; }
        public Property Property { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
