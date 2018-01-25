using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class EjemplosController : Controller
    {
        // GET: Ejemplos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SumarNumeros()//sirve para presentar la vista
        {
            return View();
        }
        [HttpPost]
        public ActionResult SumarNumeros(int num1, int num2) {

            int resultado = num1 + num2;
            ViewBag.resultado = resultado;
            return View();
        }

        public ActionResult TablaMultiplicar()//GET:TablaMultiplicar es para representar la vista
        {
            return View();
        }
        [HttpPost]//POST:TablaMultiplicar
        public ActionResult TablaMultiplicar(int numero)
        {
            
            //opcion a:  ENVIAMOS LOS RESULTADOS
            List<int> numeros = new List<int>();
            for (int i = 0; i < 10; i++)
                {
                int resultado = numero * i;
                numeros.Add(resultado);
                //  operacion += "<tr><td>"+ numero + " X "+ i +"</td><td> "+result.ToString()+" </td></tr>";


                }

            //se devuelve la coleccion como modelo
            //enviamos el numero recibido para dibujar en la vista
            ViewBag.Numero = numero;
                return View(numeros);
        }
        //opcion b: 
        public ActionResult TablaMultiplicar2()//get
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tablamultiplicar2(int numero)
        {
            List<Tabla> lista = new List<Tabla>();
            for (int i = 0; i < 10; i++){
                int resultado = numero * i;
                Tabla t = new Tabla();
                t.Resultado = resultado;
                t.Operacion = numero + " X " + i;
                lista.Add(t);
            }
            return View(lista);
        }

       
        public ActionResult Collatz(int? numero)
        {
            //PARA SABER SI TENGO QUE HACER LA CONJETURA
            //O NO, DEBO PREGUNTAR POR NUMERO
            if (numero != null)
            {
                List<int> collatz = new List<int>();
                //AQUI HAY QUE HACER COLLATZ
                while (numero != 1)
                {
                    if (numero % 2 == 0)
                    {
                        numero = numero / 2;
                    }
                    else
                    {
                        numero = numero * 3 + 1;
                    }
                    collatz.Add(numero.GetValueOrDefault());
                }
                //ENVIAMOS A LA VISTA LOS DATOS
                ViewBag.Collatz = collatz;
            }
            //RECIBAMOS EL NUMERO O NO
            //DEBEMOS ENVIAR UNA COLECCION 
            //CON NUMEROS ALEATORIOS A LA VISTA
            Random rnd = new Random();
            //MODELO ALEATORIOS
            List<int> aleatorios = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                int num = rnd.Next(1, 200);
                aleatorios.Add(num);
            }
            //ENVIAMOS EL MODELO A LA VISTA
            return View(aleatorios);

        }



        public ActionResult MejorJugador()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MejorJugador(Jugador jugador)
        {
            ViewBag.Mensaje = "Su jugador es: " + jugador.Nombre + "con equipo, " 
                + jugador.Equipo + "y con " + jugador.Edad + " años de Edad";
            return View();
        }

    }
}
