using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class ConnectionController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblConnection.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateConnection()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateConnection(TblConnection c)
        {
            db.TblConnection.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateConnection(int id)
        {
            var values=db.TblConnection.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateConnection(TblConnection c) 
        {
            var values = db.TblConnection.Find(c.ID);
            db.TblConnection.AddOrUpdate(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteConnection(int id)
        {
            var values = db.TblConnection.Find(id);
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