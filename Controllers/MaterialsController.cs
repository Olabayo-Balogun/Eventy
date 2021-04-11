using Eventy.Models;
using Eventy.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;

namespace Eventy.Controllers
{
    public class MaterialsController : Controller
    {
        private ApplicationDbContext _context;
        public MaterialsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var categories = _context.Categories.ToList();
            var viewModel = new NewMaterialViewModel
            {
                Categories = categories
            };

            return View(viewModel);
        }

            public ViewResult Index()
        {
            var materials = _context.Materials.Include(m => m.Category).ToList();

            return View(materials);
        }

        public ActionResult Details(int id)
        {
            var material = _context.Materials.Include(m => m.Category).SingleOrDefault(c => c.Id == id);

            if (material == null)
                return HttpNotFound();

            return View(material);
        }
    }
}   