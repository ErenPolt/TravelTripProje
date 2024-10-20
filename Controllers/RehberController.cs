using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;


namespace TravelTripProje.Controllers
{
    public class RehberController : Controller
    {
        Context c=new Context();
        public ActionResult Index()
        {
            var values = c.AdresBlogs.ToList();
            return View(values);
        }
       
    }
}