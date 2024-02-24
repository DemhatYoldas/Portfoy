using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class SkillsController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblSkills.ToList();
            return View(values);
        }

        public ActionResult CreateSkills()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkills(TblSkills s)
        {
            db.TblSkills.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateSkills(int id)
        {
            var value = db.TblSkills.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSkills(TblSkills S) 
        {
            db.TblSkills.AddOrUpdate(S);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkills(int id) 
        {
            var skills = db.TblSkills.Find(id);

            if (skills != null)
            {
                skills.Durum = !skills.Durum; // Durumun tersini alarak geçiş yap
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}