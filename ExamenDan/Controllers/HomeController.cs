using ExamenDan.CQRS.Inventario.Commands;
using ExamenDan.CQRS.Inventario.Queries;
using ExamenDan.DTOS;
using ExamenDan.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenDan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var Test = await _mediator.Send(new ObtenerInventarioQuery());
           
            return View(Test);
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


        public async Task<IActionResult> _TablaProducto([FromQuery] int? id = null)
        {

            var Test = await _mediator.Send(new ObtenerInventarioQuery(id));

            return PartialView(Test);



        }


        public async Task<IActionResult> ActualizarExistencia([FromBody] ProductoDTO producto)
        {

            try
            {
                var result = await _mediator.Send(new UpdateInventarioCommand(producto));
                     return Json(new { result });
            }
            catch (Exception ex)
            {

               
                throw;
            }
           

            
        }
    }
}
