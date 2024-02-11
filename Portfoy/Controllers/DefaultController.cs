using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
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
            var experience = db.TblExperience.ToList();
            var education = db.TblEducation.ToList();
            var skills = db.TblSkills.ToList();
            var model = new Tuple<List<TblExperience>, List<TblEducation>, List<TblSkills>>(experience, education, skills);

            return PartialView(model);
        }
  
        public PartialViewResult ProjectsPartial()
        {
            var projects=db.TblProject.ToList();
            var category=db.TblCategory.ToList();
            var model=new Tuple<List<TblProject>,List<TblCategory>>(projects, category);

            return PartialView(model);
        }

        public PartialViewResult TestimonialPartial()
        { 
            var values=db.TblTestimonial.ToList();
            return PartialView(values); 
        }

        public PartialViewResult ContactPartial()
        { 
            return PartialView(); 
        }

        public PartialViewResult CopyrightPartial()
        {
            return PartialView();
        }

        public PartialViewResult JavaScriptPartial()
        { return PartialView(); }

    }
}