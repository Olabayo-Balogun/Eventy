using Eventy.Models;
using Eventy.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eventy.Controllers
{
    public class MaterialsController : Controller
    {
        public ViewResult Index()
        {
            var materials = GetMaterials();

            return View(materials);
        }

        private IEnumerable<Material> GetMaterials()
        {
            return new List<Material>
            {
                new Material { Name = "Pot" },
                new Material { Name = "Spoon" }
            };
        }

        // GET: Materials/Random
        public ActionResult Random()
        {
            var material = new Material() { Name = "Pot" };
            var customers = new List<Customer>
            {
                new Customer { FirstName = "Tiwa" },
                new Customer { FirstName = "Shade" }
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