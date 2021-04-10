﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventy.Models
{
    public class Material
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal PricePerDay { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public bool IsAvailable { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}