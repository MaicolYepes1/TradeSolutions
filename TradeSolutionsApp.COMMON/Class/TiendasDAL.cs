using System.Collections.Generic;
using System.Linq;
using TradeSolutionsApp.COMMON.Interfaces;
using TradeSolutionsApp.INFRA.Context;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.COMMON.Class
{
    public class TiendasDAL : ITiendasDAL
    {
        private readonly ApplicationDataContext _context;

        public TiendasDAL(ApplicationDataContext context)
        {
            _context = context;
        }

        public IEnumerable<TiendasEntitie> Get()
        {
            var tiendas = _context.Tiendas.ToList();

            return tiendas;
        }

        public int Add(TiendasEntitie tienda) {
            if (tienda.Nombre == null)
            {
                return 0;
            }
            else
            {
                _context.Tiendas.Add(tienda);
                _context.SaveChanges();
                return tienda.Id;
            }         
        }

        public int Delete(int Id) {
            var tienda = _context.Tiendas.FirstOrDefault(x => x.Id == Id);
            _context.Tiendas.Remove(tienda);
            _context.SaveChanges();
            return tienda.Id;        
        }
    }
}