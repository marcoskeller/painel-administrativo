using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Painel_Administrativo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Painel_Administrativo.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        //Controlador para Chamar Pagina Inicial
        public IActionResult Inicio()
        {
            //ViewData["Message"] = "Página inicial do Projeto.";
            //return RedirectToPage("/Home/Inicio");
            return View();
        }

        //Controlador para Chamar Pagina Inicial
        public IActionResult AreaLogin()
        {
            //return RedirectToPage("/Home/AreaLogin");
            return View();
        }

        public IActionResult CadastroLogin()
        {
            //return RedirectToPage("/Home/AreaLogin");
            //return View("~/Views/Admin/CadastroLogin.cshtml");
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
