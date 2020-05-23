using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeSolutionsApp.COMMON.Interfaces;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.SERVICE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendasController : ControllerBase
    {
        private readonly IProductosPorTienda _productos;
        public TiendasController(IProductosPorTienda productos)
        {
            _productos = productos;
        }
        // GET: api/Tiendas
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
         var Lista = _productos.Get(id);
            if (Lista.Count() > 0)
            {
                return Ok(Lista);
            }
            else
            {
                return NoContent();
            }
        }

    }
}
