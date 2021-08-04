using Emlak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Emlak.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {

            var imgs = db.Resims.ToList();
            ViewBag.imgs = imgs;

            var ilan = db.Ilans.Include(m => m.Mahalle).Include(e => e.Tip);
            return View(ilan.ToList());
        }
        public ActionResult Detay()
        {
            return View();
        }
    }
}