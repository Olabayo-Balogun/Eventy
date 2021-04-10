using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class MembershipType
    {
        public byte Id { get; private set; }
        public string Name { get; set; }
        public decimal SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

    }
}