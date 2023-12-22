using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otomat.Models.Siniflar;

namespace Otomat.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c =new Context();
        public ActionResult Index()
        {
            var deger = c.Products.ToList();
            return View(deger);
        }
    }
}