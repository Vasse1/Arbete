using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Renter 
    {
        public int Id { get; set; }

       
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Sir name")]
        public string SirName { get; set; }

        [Required]
        [Display(Name = "e-mail")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Account number")]
        public int AccountNumber { get; set; }

        [Display(Name = "Website")]
        public string Website { get; set; }

        [Required]
        [Display(Name = "Telephone number")]
        public string TelephoneNumber { get; set; }

        [Required]
        [Display(Name = "Zip-code")]
        public int ZipCode { get; set; }

        [Required]
        [Display(Name = "Post town")]
        public string PostTown { get; set; }

        public UserProfile UserId { get; set; }
    }
}