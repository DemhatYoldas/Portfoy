using System;
using System.Collections.Generic;
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
    }
}