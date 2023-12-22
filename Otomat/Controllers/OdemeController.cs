using Otomat.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otomat.Controllers
{
    public class OdemeController : Controller
    {
        // GET: Odeme
        Context c=new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddOdeme(int id,int odenen=0)
        {
            var deger2=c.Satises.Find(id);
            ViewBag.sid = deger2.Satisid;
            var alinanfiyat = deger2.Fiyat;

            ViewBag.Odenen = odenen;
            var iade = odenen - alinanfiyat;
            ViewBag.bakiye=iade;    
            return View();
        }
        [HttpPost]
        public ActionResult AddOdeme(Odeme u)
        {
 
            c.Odemes.Add(u);
            c.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        Fis dokuman= new Fis();
        public ActionResult FisGetir(int id)
        { 
         dokuman.Deger1=c.Products.Where(x=>x.Productid==id).ToList();
         dokuman.Deger2=c.Satises.Where(x=>x.Satisid==id).ToList();
         dokuman.Deger3=c.Odemes.Where(x=>x.Id==id).ToList();
            return View(dokuman);
        }
    }
}