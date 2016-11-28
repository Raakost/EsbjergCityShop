using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gateway;
using Gateway.Models;

namespace EsbjergCityShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceGateway<Event> _eg = new Facade().GetEventGateway();

        public ActionResult Index()
        {
            var events = _eg.GetAll();
            return View(events);
        }        
    }
}