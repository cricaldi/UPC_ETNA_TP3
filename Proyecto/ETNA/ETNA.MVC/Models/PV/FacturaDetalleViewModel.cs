using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETNA.MVC.Models.PV
{
    public class FacturaDetalleViewModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nro de Factura")]
        public string NroFactura { get; set; }
        [DisplayName("Fecha Factura")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaFactura { get; set; }
        [DisplayName("Codigo Producto")]
        public int IdProducto { get; set; }
        [DisplayName("Nombre de Producto")]
        public string NombreProducto { get; set; }
        [DisplayName("Precio Venta Producto")]
        public double PrecioVentaProducto { get; set; }
        [DisplayName("Estado Producto")]
        public int EstadoProducto { get; set; }
        [DisplayName("Nombre del Cliente")]
        public string NombreCliente { get; set; }
        [DisplayName("Dias Transurridos")]
        public string DiasSinAtender{ get; set; }
    }
}