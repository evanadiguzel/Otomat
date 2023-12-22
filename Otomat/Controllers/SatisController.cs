
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Otomat.Models.Siniflar;

namespace Otomat.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        Context c = new Context();

    
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddSatis(int id,int SatisAdet=1)
        {
            
            var deger = c.Products.Find(id);
            
            var deger2 = deger.SatisFiyat;
            ViewBag.fyt = deger2;
            ViewBag.SatisAdet = SatisAdet;
            ViewBag.pid = deger.Productid;


            int sonuc = (int)(SatisAdet * deger2);
            ViewBag.toplam = sonuc;
 
            return View();
        }
        [HttpPost]
        public ActionResult AddSatis(Satis s)
        {

            var miktar = s.SatisAdet;
            var fiyat = s.Fiyat;

            int tutar =(int)( miktar * fiyat);
            s.Tutar = tutar;
           
            c.Satises.Add(s);
            c.SaveChanges();
            return RedirectToAction("AddOdeme", "Odeme");
        }

    }
}