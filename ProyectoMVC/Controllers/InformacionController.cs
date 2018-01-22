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
            else
            {
                ViewBag.Mensaje = "Aplicacion: " + app + ", version : " + dato;
            }
            return View();
        }
        //GET: VistaControladorPOST
        public ActionResult VistaControladorPOST()
        {
            return View();
        }
        //POST: VistaControladorPOST
        [HttpPost] //importante si no nunca entratrá
        public ActionResult VistaControladorPOST(String nombre)
        {
            ViewBag.Mensaje = "Su nombre es: " + nombre;
            return View();
        }
    }
}