using Organizer_BLL;
using Organizer_Entitiy;
using Organizer_UI.Filter;
using Organizer_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organizer_UI.Controllers
{
    public class LoginController : Controller
    {
       
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Index");
        }
       
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (model.UserName== null || model.Password== null)
            {
                TempData["Error"] = "Email ya da şifre girmediniz";
                return RedirectToAction("Index");
            }



            Users user = LoginBLL.LoginUser(model.UserName, model.Password);
            if (user==null)
            {
                TempData["Hata"] = "Kullanıcı Bulunamadı";
                return RedirectToAction("Index", "Login");

            }
            else
            {
                Session["User"] = user;
                return RedirectToAction("Index","Event");
                
            }
        }
    }
}