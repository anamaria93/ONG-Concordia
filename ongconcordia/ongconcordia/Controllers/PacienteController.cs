using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ongconcordia.Controllers
{
    public class PacienteController : Controller
    {
        //
        // GET: /Paciente/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Paciente/Crear
        public ActionResult Crear()
        {
            return View();
        }
	
	}
}
