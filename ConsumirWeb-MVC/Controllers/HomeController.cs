using ConsumirWeb_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsumirWeb_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            //https://jsonplaceholder.typicode.com/posts/");
            var httpClient = new HttpClient();
            var json_respuesta = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts/");
            var result = JsonConvert.DeserializeObject<List<ObjetoObtenido>>(json_respuesta);
            return View(result);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}