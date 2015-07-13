using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ETNA.MVC.Models.PV
{
    public class InformeReclamoViewModel
    {
        [Key]
        [DisplayName("Id")]
        public int InformeReclamoId { get; set; }
        
        [DisplayName("Código Informe")]
        public string CodigoInforme { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el Descripción del reclamo.")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar el Detalle del reclamo.")]
        [DisplayName("Detalle de Informe")]
        public string DetalleInforme { get; set; }
        
        [DisplayName("Fecha Aprobación")]
        [DataType(DataType.Date)]
        public System.DateTime FechaAprobacion { get; set; }
        
        [DisplayName("Fecha Elaboración")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public System.DateTime FechaElaboracion { get; set; }
        [DisplayName("Observación Aprobador")]
        public string ObservacionAprobador { get; set; }
        
        public string Estado { get; set; }
        
        [Required(ErrorMessage = "Debe Indicar el Reclamo a Atender")] 
        public int ReclamoId { get; set; }
   
        public int ElaboradoPorId { get; set; }
        
        public int AprobadoPorId { get; set; }
        
        [DisplayName("Elaborado Por")]
        public string NombreElaborador { get; set; }
        
        [DisplayName("Aprobador")]
        public string NombreAprobador { get; set; }

        [DisplayName("Estado Informe")]
        public string DescripcionEstado { get; set; }
        
        [DisplayName("Reclamo")]
        public string CodigoReclamo { get; set; }

        [DisplayName("Cliente")]
        public string NombreCliente { get; set; }
        
        [DisplayName("Fecha Reclamo")]
        [DataType(DataType.Date)]
        public System.DateTime FechaHoraReclamo { get; set; }
    }
}