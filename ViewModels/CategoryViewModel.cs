using Eventy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventy.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<Material> Materials { get; set; }
        public Category Category { get; set; }
    }
}