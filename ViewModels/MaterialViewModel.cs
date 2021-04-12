using Eventy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventy.ViewModels
{
    public class MaterialViewModel
    {
        public Material Material { get; set; }
        public List<Customer> Customers { get; set; }
    }
}