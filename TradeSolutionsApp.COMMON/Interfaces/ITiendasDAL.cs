using System.Collections.Generic;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.COMMON.Interfaces
{
    public interface ITiendasDAL
    {
        IEnumerable<TiendasEntitie> Get();
        int Add(TiendasEntitie tienda);
        int Delete(int id);
    }
}
