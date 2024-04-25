namespace IndependentRealtorApp.Models.DomainModels
{
    public class PropertyUser
    {
        // public int Id { get; set; }
        public int PublicUserId { get; set; }
        public PublicUser PublicUser { get; set; } = null!;
        public int PropertyId { get; set; } 
        public Property Property { get; set; } = null!;
    }
}
