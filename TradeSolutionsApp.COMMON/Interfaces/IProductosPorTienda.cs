using System;
using System.Collections.Generic;
using System.Text;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.COMMON.Interfaces
{
    public interface IProductosPorTienda
    {
        IEnumerable<ProductosEntitie> Get(int Id);
    }
}
