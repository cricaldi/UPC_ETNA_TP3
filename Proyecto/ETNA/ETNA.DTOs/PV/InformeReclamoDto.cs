using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using ETNA.Domain;


namespace ETNA.DTOs.PV
{
      [DataContract]
    public class InformeReclamoDto
    {
          [DataMember]
        public int InformeReclamoId { get; set; }
          [DataMember]
          public string CodigoInforme { get; set; }

          [DataMember]
          public string Descripcion { get; set; }

          [DataMember]
          public string DetalleInforme { get; set; }

          [DataMember]
          public Nullable<System.DateTime> FechaAprobacion { get; set; }
   
          [DataMember]

          public System.DateTime FechaElaboracion { get; set; }
          [DataMember]
          public string ObservacionAprobador { get; set; }
          [DataMember]

          public string Estado { get; set; }
          [DataMember]
          public int ReclamoId { get; set; }
          [DataMember]

          public int ElaboradoPorId { get; set; }
          [DataMember]
          public Nullable<int> AprobadoPorId { get; set; }

            [DataMember]
          public string NombreElaborador { get; set; }
          [DataMember]
          public string NombreAprobador { get; set; }
          [DataMember]
          public string DescripcionEstado { get; set; }
          [DataMember]
          public string CodigoReclamo { get; set; }
    }
}
