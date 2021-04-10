using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class Cart
    {
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public int TransactionId { get; private set; }
        public DateTime DateOfRental { 
            get 
            { 
                return DateOfRental.Date; 
            } 
        }
        [Required]
        public DateTime DateOfReturn { get; set; }
        public int NumberOfRentalDays { 
            get 
            {
                return (DateOfReturn - DateOfRental).Days; 
            } 
        }
        public int QuantityRequested { get; set; }
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