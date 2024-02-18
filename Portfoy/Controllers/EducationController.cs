using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class EducationController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblEducation.ToList();    
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateEducation(TblEducation e)
        {
            db.TblEducation.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var values=db.TblEducation.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation E)
        {
            db.TblEducation.Find(E.ID);
            db.TblEducation.AddOrUpdate(E);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteEducation(int id)
        {
            var values = db.TblEducation.Find(id);
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