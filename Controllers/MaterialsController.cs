using Eventy.Models;
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
            return View(material);
        }
    }
}