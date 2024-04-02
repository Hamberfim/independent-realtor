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

        public string PublicUserNameEmail { get; set; } = string.Empty;
        public string PublicUserPassword { get; set; } = string.Empty;

        public DateTime? CreatedAt { get; set; }

        /* I question if we even want to implement these given our limited dev time
         * but this may be useful for project session/cookie requirements though this many need to be approached differently.
         * Below assumes multiple realtors but I think we are simplifying to one realtor to many listings
         * TODO: review and discuss with team then FIX or DELETE */
        public int FKFollowingRealtorId { get; set; }  // will be a foreign key from Realtor
        public int FKFollowingPropertyItemId { get; set; }  // will be a foreign key & list of interested items from PropertyItem


    }
}
