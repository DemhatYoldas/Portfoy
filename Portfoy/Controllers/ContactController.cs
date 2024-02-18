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
        public ActionResult DurumContact(int id)
        {
            var values = db.TblContact.Find(id);
            return View(values);
        }
    }
}