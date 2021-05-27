using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POS_Blazor.Data
{
    public class Producto
    {
        [Required(ErrorMessage ="El Codigo del Producto es obligatorio")] 
        [StringLength(16, ErrorMessage = "Codigo demasiado largo (15 caracteres como maximo).")]
        public string? IdPro { get; set; } 
        public string Idprovee { get; set; }
        [Required(ErrorMessage = "El Nombre del Producto es obligatorio")]
        [StringLength(250, ErrorMessage = "Codigo demasiado largo (250 caracteres como maximo).")]
        public string? DescripcionLarga { get; set; }
        [Required(ErrorMessage = "El Margen es obligatorio")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public float? Frank { get; set; }
        [Required(ErrorMessage = "El Precio de Compra es Obligatorio")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public float? PreCompraS { get; set; }
        public float PreCompra { get; set; }
        public float StockActual { get; set; }
        public int IdCat { get; set; }
        public int IdMarca { get; set; }
        public string Foto { get; set; }
        [Required(ErrorMessage = "El Precio de Venta es Obligatorio")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public float? PreVntaxMenor { get; set; }
        public float PreVntaxMayor { get; set; }
        public float PreVntadolar { get; set; }
        public string UndMedida { get; set; }
        public float? PesoUnit { get; set; }
        public float? UtilidadUnit { get; set; }
        public string TipoProdcto { get; set; }
        public float? ValorPorCant { get; set; }
        public string EstadoPro { get; set; }
        public DateTime? FechaCreaProServ { get; set; }
    }
}
