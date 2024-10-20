using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class LoginController : Controller
    {
        Context c=new Context();
        public ActionResult LoginIndex()
        {
            return View();
        }
        //--------------------------------------------------------------------------
        //Kullanıcı Girişi:
        [HttpPost]
       public ActionResult LoginIndex(Admin admin)
        {
            var values = c.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if(values != null)//Eğer bilgiler doğruysa
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["UserName"]=values.UserName.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        } 
        //---------------------------------------------------------------------------------
        //Çıkış Yapma:
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","LoginIndex");
        }
    }
}