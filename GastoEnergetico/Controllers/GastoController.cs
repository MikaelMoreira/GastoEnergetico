using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GastoEnergetico.Models;

namespace GastoEnergetico.Controllers
{
    public class GastoController : Controller
    {
        private readonly ILogger<GastoController> _logger;

        public GastoController(ILogger<GastoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categorias()
        {
            return View();
        }
        
        public IActionResult Itens()
        {
            return View();
        }
        
        public IActionResult Parametros()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}