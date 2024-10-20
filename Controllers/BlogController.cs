using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context c=new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()//Blog Tablosunu Listeleme..
        {
            // var values=c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            //by.Deger3 = c.Blogs.Take(3).ToList();//3 tane blog al.
            //take: Al , Kaç tane alınacak anlamında düşün.
            by.Deger3 = c.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            //OrderByDescenfing: Azala Azala sıralama yapar. Yani İd' yi 4.id, 3.id, 2.id diye sıralar..
            by.Deger2=c.Yorumlars.OrderByDescending(x=>x.Blogid).Take(3).ToList();
            return View(by);
        }
      
       
        //-----------------------------------------------------
        //Blog Detay Sayfası:Yorumları ekleme işlemini yaptık..
        public ActionResult BlogDetay(int id)
        {

            by.Deger1 = c.Blogs.Where(x => x.Id == id).ToList();
            by.Deger2=c.Yorumlars.Where(x=>x.Blogid==id).ToList();
            return View(by);
        }
        //--------------------------------------------------------------------------------------------------
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorumlar)
        {
            c.Yorumlars.Add(yorumlar);
            c.SaveChanges();
            return PartialView();
        }
    }
}