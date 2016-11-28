using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EsbjergCityShop.Controllers
{
    public class GiftCardsController : Controller
    {
        // GET: GiftCards
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GiftCardBalance()
        {
            return View();
        }
    }
}