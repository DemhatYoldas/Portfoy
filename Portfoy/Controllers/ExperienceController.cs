using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Portfoy.Models;


namespace Portfoy.Controllers
{
    public class ExperienceController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblExperience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult CreateExperience(TblExperience E)
        {
            db.TblExperience.Add(E);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var values = db.TblExperience.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateExperience(TblExperience E)
        {
            db.TblExperience.AddOrUpdate(E);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id) 
        {
            var values = db.TblExperience.Find(id);
            if (values!=null)
            {
                values.Durum = false;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }
    }
}