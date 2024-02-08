using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class DefaultController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        { 
            return PartialView();
        }

        public PartialViewResult HeaderPartial() 
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult AboutPartial()
        {
            var values=db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult ExpertisePartial()
        {
            return PartialView();
        }

    }
}