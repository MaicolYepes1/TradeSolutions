using System.Collections.Generic;
using System.Linq;
using TradeSolutionsApp.COMMON.Interfaces;
using TradeSolutionsApp.INFRA.Context;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.COMMON.Class
{
    public class ProductosPorTienda: IProductosPorTienda
    {
        private readonly ApplicationDataContext _context;
        public ProductosPorTienda(ApplicationDataContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductosEntitie> Get(int Id) {

            var ProductosPorTienda = _context.Productos.Where(x => x.IdTienda == Id).ToList();

            if (ProductosPorTienda.Count() != 0)
            {
                return ProductosPorTienda.ToList();
            }
            else
            {
                return null;
            }            
        }
    }
}
