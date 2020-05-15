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
    public class CertificadosController : Controller
    {
        private readonly ILogger<CertificadosController> _logger;

        public CertificadosController(ILogger<CertificadosController> logger)
        {
            _logger = logger;
        }

        public IActionResult CSS()
        {
            return View();
        }

        public IActionResult HTML()
        {
            return View();
        }

        public IActionResult Python()
        {
            return View();
        }

        public IActionResult Scrum()
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
