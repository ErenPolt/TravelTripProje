using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c=new Context();
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var value = c.Blogs.Where(x => x.Id == 1).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial3()
        {
            var value = c.Blogs.ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial4()
        {
            var value = c.Blogs.Take(2).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial5()
        {
            var value = c.Blogs.Take(2).OrderByDescending(x => x.Id).ToList();
            return PartialView(value);  
        }
       
    }
}