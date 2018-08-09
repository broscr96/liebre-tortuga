using System.Threading.Tasks;
using System.Web.Mvc;
using TortugaVsLiebre.Services;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace TortugaVsLiebre.Controllers
{
    public class HomeController : Controller
    {
        static HttpClient client = new HttpClient();
        string miServidor = "https://osvaldo-lasec.herokuapp.com/";

        public ActionResult Index()
        {
            return View();
        }



        public  ActionResult Personajes()
        {
            //Task.Factory.StartNew(() => { Console.WriteLine("Código para el Tasking, async/await"); });
            

            ViewBag.Message = "Listado de animales que participan y algunas de sus características.";
            var animalService = new AnimalService();
            var model =  animalService.ObtenerAnimales();
            

            return  View(model);
        }
        

        //Inicio
        public async Task<ActionResult> Primero()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://osvaldo-lasec.herokuapp.com/primero");
            string urlContents = await getStringTask;
            ViewBag.Message = urlContents;
            return View();
        }

        //Segundo
        public async Task<ActionResult> Segundo()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://osvaldo-lasec.herokuapp.com/segundo");
            string urlContents = await getStringTask;
            ViewBag.Message = urlContents;
            return View();
        }

        //Tercero
        public async Task<ActionResult> Tercero()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://osvaldo-lasec.herokuapp.com/tercero");
            string urlContents = await getStringTask;
            ViewBag.Message = urlContents;
            return View();
        }

        //Cuarto
        public async Task<ActionResult> Cuarto()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://osvaldo-lasec.herokuapp.com/cuarto");
            string urlContents = await getStringTask;
            ViewBag.Message = urlContents;
            return View();
        }

        //Quinto
        public async Task<ActionResult> Quinto()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://osvaldo-lasec.herokuapp.com/quinto");
            string urlContents = await getStringTask;
            ViewBag.Message = urlContents;
            return View();
        }
        //Sexto
        public async Task<ActionResult> Sexto()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://osvaldo-lasec.herokuapp.com/sexto");
            string urlContents = await getStringTask;
            ViewBag.Message = urlContents;
            return View();
        }

        //Septimo
        public async Task<ActionResult> Septimo()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("https://osvaldo-lasec.herokuapp.com/septimo");
            string urlContents = await getStringTask;
            ViewBag.Message = urlContents;
            return View();
        }

        //fin
        public ActionResult Fin()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

    }

}