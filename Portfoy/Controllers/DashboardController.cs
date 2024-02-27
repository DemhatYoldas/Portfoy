using Portfoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class DashboardController : Controller
    {
        DbPortfolioEntities db = new DbPortfolioEntities();
        public ActionResult Index()
        {
            var contact=db.TblContact.ToList();
            
            ViewBag.isreadCount = db.TblContact.Where(x => x.İsRead == true).Count();
            ViewBag.project = db.TblProject.Count();
            ViewBag.referance = db.TblTestimonial.Count();

            // 90 ile 100 arasında olan becerilerin adlarını al
            var bestSkills = db.TblSkills
                .Where(x => x.progressbar >= 90 && x.progressbar <= 100)
                .Select(x => x.Title)
                .ToList();

            // Eğer en az bir beceri varsa, adlarını ViewBag.Bestskills'e ata
            if (bestSkills.Any())
            {
                ViewBag.Bestskills = string.Join(", ", bestSkills);
            }

            return View(contact);
        }
    }
}