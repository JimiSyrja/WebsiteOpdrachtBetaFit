using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebsiteOdrachtBetaFit.Models;
using MySql.Data;

namespace WebsiteOdrachtBetaFit.Controllers

{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // alle producten ophalen
            var rows = DatabaseConnector.GetRows("select * from locaties");

            // lijst maken om alle namen in te stoppen
            List<string> names = new List<string>();

            foreach (var row in rows)
            {
                // elke naam toevoegen aan de lijst met namen
                names.Add(row["name"].ToString());
            }

            // de lijst met namen in de html stoppen
            return View(names);
        }
        [Route("Locaties")]
        public IActionResult locaties()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new TheBios.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}