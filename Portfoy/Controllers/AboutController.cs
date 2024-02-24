using Portfoy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class AboutController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblAbout.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(TblAbout A)
        {
            db.TblAbout.AddOrUpdate(A);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAbout(int id)
        {
            var skills = db.TblAbout.Find(id);

            if (skills != null)
            {
                skills.Durum = !skills.Durum; // Durumun tersini alarak geçiş yap
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}