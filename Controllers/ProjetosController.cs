using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SitePessoal.Models;

namespace SitePessoal.Controllers
{
    public class ProjetosController : Controller
    {
        private readonly ILogger<ProjetosController> _logger;

        public ProjetosController(ILogger<ProjetosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Da2()
        {
            return View();
        }

        public IActionResult Da1()
        {
            return View();
        }

        public IActionResult Outsystems()
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