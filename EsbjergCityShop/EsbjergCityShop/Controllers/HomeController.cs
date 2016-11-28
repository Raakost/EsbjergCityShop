using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EsbjergCityShop.Models;
using Gateway;
using Gateway.Models;

namespace EsbjergCityShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceGateway<Event> _eg = new Facade().GetEventGateway();

        public ActionResult Index(int page = 1)
        {
            var events = _eg.GetAll();
            var itemsPrPage = 3;

            events = events.Where(x => x.DateOfEvent > DateTime.Now).OrderBy(x => x.DateOfEvent).ToList();

            var pagination = new PaginatedEventViewModel
            {
                ItemsPrPage = itemsPrPage,
                Page = page,
                Events = events.Skip((page - 1) * itemsPrPage).Take(itemsPrPage).ToList(),
                TotalEvents = events.Count
            };

            return View(pagination);
        }
    }
}