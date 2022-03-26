using FinalCine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalCine.Controllers
{
    public class CineController : Controller
    {
        // GET: Cine
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregar()
        {
            GestorCine GC = new GestorCine();
            Cine C = new Cine();
            C.pelicula = new Pelicula();
            C.nombrePelicula = GC.ObtenerNombres();
            return View(C);
        }

        [HttpPost]
        public ActionResult Agregar(Cine nuevaPelicula)
        {
            GestorCine GC = new GestorCine();
            GC.Agregar(nuevaPelicula.pelicula);
            return View("Index");
        }

        public ActionResult Listar()
        {
            GestorCine GC = new GestorCine();
            List<PeliculaDto> lista = GC.Listar();
            return View(lista);
        }


    }
}
