namespace IndependentRealtorApp.Models.DomainModels
{
    public interface IUser
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserEmail { get; set; }
        public string FullName { get; }

        public List<User> GetUsers();
    }
}
