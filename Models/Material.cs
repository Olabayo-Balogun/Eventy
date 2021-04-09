using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class Material
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal PricePerDay { get; set; }
    }
}