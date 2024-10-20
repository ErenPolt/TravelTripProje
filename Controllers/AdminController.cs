using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;


namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();

        [Authorize]
        public ActionResult Index()//Blog Listeleme
        {
            var values = c.Blogs.ToList();
            return View(values);
        }
        //-----------------------------------------------------------------------------------
        //Blog Ekleme:
        [HttpGet]
        public ActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //---------------------------------------------------------------------------------------
        //Blog Silme:
        public ActionResult DeleteBlog(int id)
        {
            var values = c.Blogs.Find(id);
            c.Blogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //-------------------------------------------------------------------------------
        //Blog Güncelleme:
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var values = c.Blogs.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var values = c.Blogs.Find(blog.Id);
            values.Title = blog.Title;
            values.Date = blog.Date;
            values.Description = blog.Description;
            values.BlogImage = blog.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //----------------------------------------------------------------------------------------------------
        //Blog Detay:
        public ActionResult BlogDetails(int id)
        {
            var values = c.Yorumlars.Where(x => x.Blogid == id).FirstOrDefault();
            return View(values);
        }

        //---------------------------------------------------------------------------------------------------
        //Yorumlar Tablosu Listeleme:
        public ActionResult CommentList()
        {
            var values = c.Yorumlars.ToList();
            return View(values);
        }
        //---------------------------------------------------------------------------------------------------
        //Yorumlar Tablosu Silme İşlemi:
        public ActionResult DeleteComment(int id)
        {
            var values = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(values);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        //----------------------------------------------------------------------------------------------------
        //Yorumlar Tablosu Güncelleme İşlemi:
        [HttpGet]
        public ActionResult UpdateComment(int id)
        {
            var values = c.Yorumlars.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateComment(Yorumlar yorumlar)
        {
            var values = c.Yorumlars.Find(yorumlar.Id);
            values.userName = yorumlar.userName;
            values.Mail = yorumlar.Mail;
            values.Comment = yorumlar.Comment;
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        //----------------------------------------------------------------------------------------------
        //Hakkımızda Tablosu Listele:
        public ActionResult AboutIndex()
        {
            var value = c.Hakkimizdas.ToList();
            return View(value);
        }
        //--------------------------------------------------------------------------------------------
        //Hakkımzda TAblosu Güncelleme:
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = c.Hakkimizdas.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAbout(Hakkimizda hakkimizda)
        {
            var value = c.Hakkimizdas.Find(hakkimizda.Id);
            value.imageUrl = hakkimizda.imageUrl;
            value.Description = hakkimizda.Description;
            c.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
        //--------------------------------------------------------------------------------
        //Oteller Listeleme:
        public ActionResult OtelIndex()
        {
            var value = c.AdresBlogs.ToList();
            return View(value);
        }
        //----------------------------------------------------------------------------------
        //Otel Ekleme:
        [HttpGet]
        public ActionResult CreateOtel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOtel(AdresBlog adresBlog)
        {
            c.AdresBlogs.Add(adresBlog);
            c.SaveChanges();
            return RedirectToAction("OtelIndex");
        }
        //------------------------------------------------------------------------
        //Otel Güncelle:
        [HttpGet]
        public ActionResult UpdateOtel(int id)
        {
            var values = c.AdresBlogs.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateOtel(AdresBlog adresBlog)
        {
            var values = c.AdresBlogs.Find(adresBlog.Id);
            values.Title = adresBlog.Title;
            values.address = adresBlog.address;
            values.Subject = adresBlog.Subject;
            c.SaveChanges();
            return RedirectToAction("OtelIndex");
        }
        //----------------------------------------------------------------------------------
        //Otel Silme:
        public ActionResult DeleteOtel(int id)
        {
            var values = c.AdresBlogs.Find(id);
            c.AdresBlogs.Remove(values);
            c.SaveChanges();
            return RedirectToAction("OtelIndex");
        }
    }
}