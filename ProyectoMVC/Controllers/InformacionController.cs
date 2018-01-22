using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class InformacionController : Controller
    {
        // GET: Informacion
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VistaControladorGET(String app, int? version) //int? Significa que el numero ya admite nullos .ya es opcional la version y nullable                                                                                        
        {
            String dato = version.GetValueOrDefault().ToString();
            if (app != null)
            {
                ViewBag.Mensaje = "Aplicacion: " + app + ", version : " + version.GetValueOrDefault();
            }
            return View();
        }
    }
}