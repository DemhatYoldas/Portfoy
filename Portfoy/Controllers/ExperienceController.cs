using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
    }
}