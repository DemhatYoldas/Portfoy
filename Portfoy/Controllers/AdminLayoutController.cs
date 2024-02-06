using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class AdminLayoutController : Controller
    {
        public ActionResult _Layout() 
        {
            return PartialView();
        }

        public PartialViewResult _HeaderPartial() 
        {
            return PartialView();
        }

        public PartialViewResult _SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult _TopbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult _ScriptPartial()
        {
            return PartialView();
        }
    }
}