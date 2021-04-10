using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class Cart
    {
        public int TransactionId { get; private set; }
        public DateTime DateOfRental { 
            get 
            { 
                return DateOfRental; 
            } 
            set 
            { 
                DateTime now = DateTime.Today; 
            } 
        }
        public DateTime DateOfReturn { get; set; }
        public int NumberOfRentalDays { 
            get 
            {
                return (DateOfReturn - DateOfRental).Days; 
            } 
        }
        public List<Material> Materials { get; set; }
        public string MaterialName { get; }
        public decimal MaterialPricePerDay { get; }
        public string MaterialImage { get; }
        public int QuantityRequested { get; set; }
        public decimal TotalPricePerMaterial 
        { get 
            { 
                return (MaterialPricePerDay * NumberOfRentalDays)* QuantityRequested; 
            } 
        }
    }
}