using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            ViewData["PRUEBA"] = "pruebas con viewdata";
            ViewBag.Contenido = "Contenido del viewbag";
            Persona persona = new Persona();
            persona.Nombre = "Miles";
            persona.Apellidos = "Davis";
            persona.Edad = 21;
            return View(persona);
            
        }
        public ActionResult Lista()
        {

            ConjuntoPersonas lista = new ConjuntoPersonas();
            Persona personas = new Persona();
            Persona persona2 = new Persona();
            personas.Nombre = "Miles";
            personas.Apellidos = "Davis";
            personas.Edad = 21;
            lista.ListaPersonas.Add(personas);
            personas.Nombre = "John";
            personas.Apellidos = "Coltrane";
            personas.Edad = 19;
            lista.ListaPersonas.Add(personas);
            return View(personas);

        }
       
    }
}