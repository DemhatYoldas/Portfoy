using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class ProjectController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblProject.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.TblProject.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject P)
        {
            db.TblProject.AddOrUpdate(P);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteProject(int id)
        {
            var project = db.TblProject.Find(id);

            if (project != null)
            {
                project.Durum = !project.Durum; // Durumun tersini alarak geçiş yap
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}