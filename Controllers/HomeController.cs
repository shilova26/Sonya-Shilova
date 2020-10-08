using coffeehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace coffeehouse.Controllers
{
    public class HomeController : Controller
    {
        CardContext db = new CardContext();
        public ActionResult Index()
        {

            return View(db.Cards.ToList());
        }

       
    }
}