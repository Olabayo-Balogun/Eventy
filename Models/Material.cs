using System;
using System.ComponentModel.DataAnnotations;

namespace Eventy.Models
{
    public class Material
    {
        public int Id { get; private set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Daily Rental Fee")]
        public decimal PricePerDay { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public string Image { get; set; }

        [Required]
        [Display(Name = "Available?")]
        public bool IsAvailable { get; set; }

        [Required]
        [Display(Name = "Category")]
        public Category Category { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}