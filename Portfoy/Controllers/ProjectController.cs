using System;
using System.Collections.Generic;
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

        public ActionResult CreateProject()
        {
            return View();
        }
    }
}