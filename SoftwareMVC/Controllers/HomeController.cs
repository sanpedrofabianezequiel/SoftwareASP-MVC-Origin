using SoftwareMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //Creamos una Instancia de nuestro ServicePelicula
            var peliculaService = new PeliculasService();
            var model=peliculaService.ObtenerPelicula();//Retorna un tipo Pelicula
            var models = peliculaService.ObtenerPeliculas();
            return View(models);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}