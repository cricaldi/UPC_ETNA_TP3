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
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
    }
}