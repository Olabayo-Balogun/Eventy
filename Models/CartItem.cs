using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class CartItem
    {
        [Key]
        public int TransactionId { get; private set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; }

        [Required]
        [Display(Name = "Renting Date")]
        public DateTime DateOfRental { 
            get 
            { 
                return DateOfRental.Date; 
            } 
        }
        [Required]
        [Display(Name = "Return Date")]
        public DateTime DateOfReturn { get; set; }

        [Display(Name = "Number of renting days")]
        public int NumberOfRentalDays { 
            get 
            {
                return (DateOfReturn - DateOfRental).Days; 
            } 
        }

        [Required]
        [Display(Name = "Quantity")]
        public int QuantityRequested { get; set; }

        [Display(Name = "Price")]
        public decimal TotalPricePerMaterial
        {
            get
            {
                return (MaterialPricePerDay * NumberOfRentalDays) * QuantityRequested;
            }
        }
        public List<Material> Materials { get; set; }
        public string MaterialName { get; }
        public decimal MaterialPricePerDay { get; }
        public string MaterialImage { get; }
        
    }
}