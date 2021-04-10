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
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int Age { get { return ((DateTime.Today - DateOfBirth).Days)/365; } }
        [Required]
        [StringLength(14)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(250)]
        public string HomeAddress { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public string Image { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; }
        public Cart Cart { get; }
        public int CartTransactionId { get; }
    }
}