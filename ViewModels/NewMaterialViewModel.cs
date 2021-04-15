using Eventy.Models;
using System.Collections.Generic;

namespace Eventy.ViewModels
{
    public class NewMaterialViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Material Material { get; set; }
    }
}