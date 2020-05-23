using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TradeSolutionsApp.COMMON.Models
{
    public class ProductosModel
    {
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int SKU { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public int IdTienda { get; set; }
        [Required]
        public IFormFile Imagen { get; set; }
    }
}
