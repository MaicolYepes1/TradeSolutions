using System;
using System.Collections.Generic;
using System.Text;
using TradeSolutionsApp.COMMON.Models;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.COMMON.Interfaces
{
    public interface IProductosDAL
    {
        IEnumerable<ProductosEntitie> Get();

        int Add(ProductosModel Model);

    }
}
