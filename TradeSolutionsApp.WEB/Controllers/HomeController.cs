using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TradeSolutionsApp.COMMON.Interfaces;
using TradeSolutionsApp.COMMON.Models;
using TradeSolutionsApp.INFRA.Entities;
using TradeSolutionsApp.WEB.Models;

namespace TradeSolutionsApp.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITiendasDAL _tienda;
        private readonly IProductosDAL _producto;
        int IdTienda = 0;

        public HomeController(ILogger<HomeController> logger, ITiendasDAL tienda, IProductosDAL producto)
        {
            _logger = logger;
            _tienda = tienda;
            _producto = producto;
        }

        public IActionResult Index(TiendasEntitie model)
        {
            _tienda.Add(model);
            var tiendas = _tienda.Get();
            return View(tiendas);
        }

        public IActionResult EliminarRegistro(int Id)
        {
            var result = _tienda.Delete(Id);
            return Redirect("~/home");
        }
        public IActionResult Privacy(ProductosModel model, int Id)
        {
            IdTienda = Id;
            model.IdTienda = Id;
            model.SKU = Id;

            _producto.Add(model);            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
