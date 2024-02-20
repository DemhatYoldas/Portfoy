using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portfoy.Models;

namespace Portfoy.Controllers
{
    public class ProfileController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
       public ActionResult Index()
        {
           var adminbar=db.TblAdminbar.ToList();
           var skills=db.TblSkills.ToList();
            var model= new Tuple<List<TblAdminbar>,List<TblSkills>>(adminbar,skills);
            return View(model);
        }
    }
}