﻿/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

namespace IndependentRealtorApp.Models
{
    public class Realtor
    {
        /* TODO: data annotations here or fluent API use in the DBContext seed file */

        // using verbose naming conventions for field property clarity

        // by convention, this is the primary key without the need for the [Key] annotation attribute
        public int RealtorId { get; set; }

        public string FullName { get; set; } = string.Empty;

        // this is modified from the original schema to be the username/email
        public string UserNameEmail { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty;
        public string imageUrl { get; set; } = string.Empty;

        // its im my original schema but do we really even need this?
        public DateTime? CreatedAt { get; set; }  

        /* TODO: I feel like there should be an interface somewhere between these models
         *  but I'm not 100% when or where yet */

        // from the other models, because this is a one to many relationship
        public int PropertyItemId { get; set; }
        public PropertyItem PropertyItem { get; set; } = null!;

        public int PublicUserId { get; set; }
        public PublicUser PublicUser { get; set; } = null!;

    }
}
