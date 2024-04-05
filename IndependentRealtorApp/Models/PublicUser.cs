/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

namespace IndependentRealtorApp.Models
{
    public class PublicUser
    {
        /* TODO: data annotations here or fluent API use in the DBContext seed file */

        public int PublicUserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PublicUserNameEmail { get; set; } = string.Empty;
        public string PublicUserPassword { get; set; } = string.Empty;


        // from the other model (one PublicUser to many PropertyItems)
        public int PropertyItemId { get; set; }
        public PropertyItem PropertyItem { get; set; } = null!;

    }
}
