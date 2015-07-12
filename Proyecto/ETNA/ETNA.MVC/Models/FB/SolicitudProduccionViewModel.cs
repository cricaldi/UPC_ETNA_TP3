using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETNA.MVC.Models.FB
{
    public class SolicitudProduccionViewModel
    {
        [DisplayName("Código solicitud")]
        public string SolicitudProdId { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Fecha de solicitud")]
        public DateTime FecSol { get; set; }

        [DisplayName("Cant. personal")]
        public int CantPersonal { get; set; }

        [DisplayName("Cant. insumos")]
        public int CantInsumos { get; set; }

        [DisplayName("Cant. maquinarias")]
        public int CantMaquinaria { get; set; }

    }
}