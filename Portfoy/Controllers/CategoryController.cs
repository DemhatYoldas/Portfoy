using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class CategoryController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblCategory.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateCategory()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(TblCategory c)
        {
            db.TblCategory.Add(c);
            db.SaveChanges();   
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory c)
        {
            var value = db.TblCategory.Find(c.ID);
            db.TblCategory.AddOrUpdate(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            if (value!=null)
            {
                value.Durum = false;
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