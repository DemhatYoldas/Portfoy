using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class TestimonialController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblTestimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial t)
        {
            db.TblTestimonial.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var values = db.TblTestimonial.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial T)
        {
            db.TblTestimonial.AddOrUpdate(T);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var testimonial = db.TblTestimonial.Find(id);

            if (testimonial != null)
            {
                testimonial.Durum = !testimonial.Durum; // Durumun tersini alarak geçiş yap
                db.SaveChanges();
            }

            return RedirectToAction("Index"); ;
        }

    }
}