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

        [StringLength (50)]
        public string FirstName { get; set; }


        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get { return ((DateTime.Today - DateOfBirth).Days)/365; } }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        [StringLength(250)]
        public string HomeAddress { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public string Image { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; }
    }
}