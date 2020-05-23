using System;
using System.ComponentModel.DataAnnotations;

namespace TradeSolutionsApp.COMMON.Models
{
    public class TiendasModel
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaCreacion { get; set; }
    }
}
