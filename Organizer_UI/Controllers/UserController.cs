using Organizer_BLL;
using Organizer_Entitiy;
using Organizer_UI.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Organizer_UI.Controllers
{
    public class UserController : Controller
    {
       
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
     
        [HttpGet]
        public ActionResult AddUser()
        {
            Users user = new Users();
            return View(user);
        }
        [HttpPost]
        public ActionResult InsertUser(Users user)
        {
            UserBLL.InsertUser(user);
            return RedirectToAction("Index","Event");
        }
    }
}