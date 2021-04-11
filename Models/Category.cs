using System.ComponentModel.DataAnnotations;

namespace Eventy.Models
{
    public class Category
    {
        public int Id { get; private set; }

        [Display(Name = "Category")]
        public string Name { get; set; }
    }
}