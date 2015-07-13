using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain
{
    [DataContract]
    public class TB_PR_SolicitudProduccion
    {
        [DataMember]
        public string SolicitudProdId { get; set; }
        [DataMember]
        public int PlanId { get; set; }
        [DataMember]
        public DateTime FecSol { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public int CantPersonal { get; set; }
        [DataMember]
        public int CantInsumos { get; set; }
        [DataMember]
        public int CantMaquinaria { get; set; }
        [DataMember]
        public string ResponsableId { get; set; }
        [DataMember]
        public string SupervisorId { get; set; }
        [DataMember]
        public string SolicitanteId { get; set; }
        [DataMember]
        public string Glosa { get; set; }
        [DataMember]
        public string EstadoSol { get; set; }
        [DataMember]
        public string ObsSol { get; set; }
        [DataMember]
        public string Id_MotivoRechazo { get; set; }

    }
}
