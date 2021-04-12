using System.Collections.Generic;

namespace Eventy.Models
{
    public class RentalCart
    {
        public Customer Customers { get; }
        public List<Material> Materials { get; set; }
        public int RentingDays { get; set; }
    }
}