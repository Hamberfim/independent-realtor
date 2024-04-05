/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

namespace IndependentRealtorApp.Models
{
    public class Realtor
    {
        /* TODO: data annotations here or fluent API use in the DBContext seed file */

        public int RealtorId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string UserNameEmail { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty;
        public string imageUrl { get; set; } = string.Empty;  // fixed url to image dir, no upload functionality


        // from the other model  (one Realtor to many PropertyItems)
        public int PropertyItemId { get; set; }
        public PropertyItem PropertyItem { get; set; } = null!;  

    }
}
