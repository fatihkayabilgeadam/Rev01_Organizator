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
    public class EventController : Controller
    {
    
        // GET: Event
        public ActionResult Index()
        {
            List<Events> eventList = EventBLL.GetEvents();
            return View(eventList);
        }
        [HttpGet]
        public ActionResult AddEvent()
        {
            Events emptyEvent = new Events();
            return View(emptyEvent); 
        }
        [HttpPost]
        public ActionResult AddEvent(Events filledEvent)
        {
            EventBLL.AddEvent(filledEvent);
            return RedirectToAction("Index");
        }


    }
}