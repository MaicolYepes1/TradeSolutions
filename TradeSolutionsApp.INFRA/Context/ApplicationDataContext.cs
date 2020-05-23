using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TradeSolutionsApp.INFRA.Entities;

namespace TradeSolutionsApp.INFRA.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        {

        }
        public DbSet<TiendasEntitie> Tiendas { get; set; }
        public DbSet<ProductosEntitie> Productos { get; set; }
    }
}
