using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain
{
    public class TB_PR_LoteFabricacion
    {
        public int LoteId { get; set; }
        public string SolId { get; set; }
        public int CantInsumos { get; set; }
        public int CantMaquina { get; set; }
        public int CantPersonal { get; set; }
        public DateTime FecSol { get; set; }
        public DateTime FecInicial { get; set; }
        public DateTime FecFinal { get; set; }
        public string SolicitanteId { get; set; }
        public int EstLote { get; set; }
        public string GlosaOrd { get; set; }
    }
}
