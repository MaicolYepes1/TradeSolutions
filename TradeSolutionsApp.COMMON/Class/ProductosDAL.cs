using System;
using System.Collections.Generic;
using System.Text;
using TradeSolutionsApp.COMMON.Interfaces;
using TradeSolutionsApp.COMMON.Models;
using TradeSolutionsApp.INFRA.Context;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.COMMON.Class
{
    public class ProductosDAL : IProductosDAL
    {
        private readonly ApplicationDataContext _context;
        public ProductosDAL(ApplicationDataContext context)
        {
            _context = context;
        }
        public int Add(ProductosModel Model)
        {
            ProductosEntitie Producto = new ProductosEntitie();
            Producto.Nombre = Model.Nombre;
            Producto.SKU = Model.SKU;
            Producto.Valor = Model.Valor;
            Producto.Descripcion = Model.Descripcion;
            Producto.IdTienda = Model.IdTienda;
            if (Model.Nombre != null)
            {
                _context.Productos.Add(Producto);
                _context.SaveChanges();
                return Model.IdProducto;
            }
            else
            {
                return 0;
            }            
        }

        public IEnumerable<ProductosEntitie> Get()
        {
            throw new NotImplementedException();
        }
    }
}
