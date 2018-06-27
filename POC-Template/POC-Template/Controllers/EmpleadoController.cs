using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POC_Template.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Index
        public ActionResult VerEmpleado()
        {
            return View();
        }

        public ActionResult AltaEmpleado()
        {
            return View();
        }
    }
}