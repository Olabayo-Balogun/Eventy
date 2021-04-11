using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class Customer
    {
        public int Id { get; private set; }

        [Required]
        [StringLength (50)]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get { return FirstName + " " + LastName; } }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get ; set; }

        [Display(Name = "Age")]
        public int Age { get { return ((DateTime.Today - DateOfBirth).Days)/365; } }

        [Required]
        [StringLength(11)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(110)]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }

        [Required]
        [Display(Name = "Subscribe to Newsletter?")]
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Profile picture")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Id")]
        public byte MembershipTypeId { get; }
    }
}