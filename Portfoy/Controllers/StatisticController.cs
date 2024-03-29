﻿using Portfoy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities db=new DbPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCategory=db.TblProject.Count();
            ViewBag.messgaCount=db.TblContact.Count();
            ViewBag.netProject = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.isreadCount=db.TblContact.Where(x=>x.İsRead==true).Count();
            ViewBag.project = db.TblProject.Count();
            ViewBag.phpproject = db.TblProject.Where(x=>x.ProjectCategory==2).Count();
            ViewBag.OfmessgaCount = db.TblContact.Where(x=>x.İsRead==false).Count();
            ViewBag.skills=db.TblSkills.Count();
            ViewBag.referance=db.TblTestimonial.Count();
            //ViewBag.lastprojectname = db.LastProjectName().firstorDefault();
            return View();
        }
    }
}