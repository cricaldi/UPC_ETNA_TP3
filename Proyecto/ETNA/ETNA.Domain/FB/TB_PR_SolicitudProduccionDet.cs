using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain
{
    public class TB_PR_SolicitudProduccionDet
    {
        public string SolicitudProdId { get; set; }
        public int SolicitudProdDetId { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public string MaqId { get; set; }
        public string InsumoId { get; set; }
        public int EmpleadoId { get; set; }
        public int CantMaqSol { get; set; }
        public int CantInsSol { get; set; }
        public int CantEmpSol { get; set; }
        public int CantMaqDis { get; set; }
        public int CantInsDis { get; set; }
        public int CantEmpDis { get; set; }
        public int LineaId { get; set; }
        public string ObsSol { get; set; }
    }
}
