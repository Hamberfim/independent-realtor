﻿/* Name: independent-realtor
 * Authors: Anthony Hamlin, Brody Boell, Cole Cooley
 * CIS174 - Final Project - Spring 2024
 * NOTES: We will use a mix of conventions, annotations and fluent API to config DB context and db models
 */

using System.ComponentModel.DataAnnotations.Schema;

namespace IndependentRealtorApp.Models
{
    // some model names changed from original schema for additional clarity
    public class PropertyItem
    {
        /* TODO: data annotations here or fluent API use in the DBContext seed file */

        public int PropertyItemId { get; set; }
        public string PropertyItemTitle { get; set; } = string.Empty;
        public string PropertyItemDescription { get; set; } = string.Empty;
        public string PropertyItemAddress { get; set; } = string.Empty;
        public string PropertyItemCity { get; set; } = string.Empty;
        public string PropertyItemState { get; set; } = string.Empty;
        public string PropertyItemZip { get; set; } = string.Empty;
        public string PropertyItemStatus { get; set; } = string.Empty;
        public string imageUrl { get; set; } = string.Empty;  // fixed url to image dir, no upload functionality


        //[ForeignKey("Realtor")]
        //public int RealtorId { get; set; }
        //public Realtor Realtor { get; set; } = null!;

        //[ForeignKey("PublicUser")]
        //public int PublicUserId { get; set; }
        //public PublicUser PublicUser { get; set; } = null!;


    }
}
