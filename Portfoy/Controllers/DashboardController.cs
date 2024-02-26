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
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.isreadCount = db.TblContact.Where(x => x.İsRead == true).Count();
            return View();
        }
    }
}