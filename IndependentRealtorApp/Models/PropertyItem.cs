/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

namespace IndependentRealtorApp.Models
{
    // some model names changed from original schema for additional clarity
    public class PropertyItem
    {
        /* TODO: data annotations here or fluent API use in the DBContext seed file */

        // using verbose naming conventions for field property clarity
        public int PropertyItemId { get; set; }

        public string PropertyItemTitle { get; set; } = string.Empty;
        public string PropertyItemDescription { get; set; } = string.Empty;  // this was 'body' in the original schema

        // addition field properties added to model that are not in the original schema
        public string PropertyItemAddress { get; set; } = string.Empty;
        public string PropertyItemCity { get; set; } = string.Empty;
        public string PropertyItemState { get; set; } = string.Empty;
        public string PropertyItemZip { get; set; } = string.Empty;
        public string PropertyItemStatus { get; set; } = string.Empty;  // this was 'status' in the original schema

        public DateTime? CreatedAt { get; set; }

    }
}
