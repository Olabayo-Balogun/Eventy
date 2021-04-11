using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class MembershipType
    {
        public byte Id { get; private set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Signup Fee")]
        public decimal SignUpFee { get; set; }

        [Required]
        [Display(Name = "Duration (in months)")]
        public byte DurationInMonths { get; set; }

        [Required]
        [Display(Name = "Discount Rate (%)")]
        public byte DiscountRate { get; set; }

    }
}