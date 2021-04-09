using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class Customer
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
    }
}