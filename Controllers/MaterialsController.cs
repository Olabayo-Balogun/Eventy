using Eventy.Models;
using Eventy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eventy.Controllers
{
    public class MaterialsController : Controller
    {
        // GET: Materials/Random
        public ActionResult Random()
        {
            var material = new Material() { Name = "Pot" };
            var customers = new List<Customer>
            {
                new Customer {Name = "shade"},
                new Customer {Name = "Tiwa"}
            };

            var viewModel = new RandomMaterialViewModel
            {
                Material = material,
                Customers = customers
            };

            return View(viewModel);
        }

    }
}   