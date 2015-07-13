using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ETNA.MVC.Models.PV
{
    public class ReclamoViewModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Código")]
        public string CodigoReclamo { get; set; }

        [DisplayName("Fecha Reclamo")]
        public System.DateTime FechaHoraReclamo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el motivo del reclamo.")]
        public string Motivo { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Detalle del reclamo.")]
        public string Detalle { get; set; }

        public string Observaciones { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha Respuesta")]
        public System.DateTime FechaRespuesta { get; set; }

        [Required(ErrorMessage = "Debe Indicar la Factura y el Producto a Reclamar")]
        public int IdFacturaDetalle { get; set; }  
        public string Estado { get; set; }
        [DisplayName("Registrado Por")]
        public string NombreRegistrador { get; set; }
        [DisplayName("Estado")]
        public string DescripcionEstado { get; set; }
        [Required(ErrorMessage = "Debe ingresar un numero de Factura valido")]
        [DisplayName("Factura")]
        public string NumeroFactura { get; set; }
        [DisplayName("Producto")]
        public string NombreProducto { get; set; }
        [DisplayName("Cliente")]
        public string NombreCliente { get; set; }
        [DisplayName("Días sin Atender")]
        public string DiasSinAtender { get; set; }
    }
}