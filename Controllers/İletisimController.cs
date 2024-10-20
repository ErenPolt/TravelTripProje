using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        Context c=new Context();
        public ActionResult Index()
        {
            var values = c.İletisims.ToList();
            return View(values);
        }
        //------------------------------------------------------------------------
        //iletişim oluşturma:
        [HttpGet]
        public PartialViewResult mesajGonder(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult mesajGonder(İletisim iletisim)
        {
            c.İletisims.Add(iletisim);
            c.SaveChanges();
            return PartialView();
        }
    }
}