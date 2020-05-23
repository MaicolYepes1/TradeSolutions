using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace TradeSolutionsApp.INFRA.Entities
{
    [Table(name: "Productos")]
    public class ProductosEntitie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        public Byte[] Imagen { get; set; }
    }
}
