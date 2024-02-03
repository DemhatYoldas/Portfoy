using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _HeaderPartial() 
        {
            return PartialView();
        }

        public ActionResult _SidebarPartial()
        {
            return PartialView();
        }

        public ActionResult _Topbar()
        {
            return PartialView();
        }

        public ActionResult _ScriptPartial()
        {
            return PartialView();
        }
    }
}