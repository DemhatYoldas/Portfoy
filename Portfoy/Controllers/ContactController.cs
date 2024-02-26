using Portfoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class ContactController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateContact() 
        {
           
            return View(); 
        }

        [HttpPost]
        public ActionResult CreateContact(TblContact C) 
        {
             C.SendDate = DateTime.Now;
            C.İsRead = true;
            db.TblContact.Add(C);
            db.SaveChanges();
            return RedirectToAction("Index","Default");
        }

        //public ActionResult Contactcount()
        //{
        //    // gelen msj sayısını göstermek için yaptık ama eksik var sanırım topbarpartial içersinde viewbag çalışmadı 
        //    int readMessageCount = db.TblContact.Count(c => c.İsRead==true);
        //    ViewBag.ContactCount = readMessageCount;
        //    return View();
        //}
       
        public ActionResult DurumContact(int id)
        {
            var values = db.TblContact.Find(id);
            return View(values);
        }

        public ActionResult isreadContact(int id)
        {
            var value = db.TblContact.Find(id);
            if (value != null)
            {
                value.İsRead = false;
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