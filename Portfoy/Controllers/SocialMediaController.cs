using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class SocialMediaController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            var values=db.TblSocialMedia.ToList();  
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia s)
        {
            db.TblSocialMedia.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var values = db.TblSocialMedia.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia S)
        {
            db.TblSocialMedia.AddOrUpdate(S);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var social = db.TblSocialMedia.Find(id);

            if (social != null)
            {
                social.Durum = !social.Durum; // Durumun tersini alarak geçiş yap
                db.SaveChanges();
            }

            return RedirectToAction("Index"); ;
        }
    }
}