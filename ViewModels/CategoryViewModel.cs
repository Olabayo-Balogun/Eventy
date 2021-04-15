using Eventy.Models;
using System.Collections.Generic;

namespace Eventy.ViewModels
{
    public class CategoryViewModel
    {
        public IEnumerable<Material> Materials { get; set; }
        public Category Category { get; set; }
    }
}