using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain
{
    public class TB_PR_Maquinaria
    {
        public string MaqId { get; set; }
        public string Descripcion { get; set; }
        public int StockDispMaquina { get; set; }
        public int StockResMaquina { get; set; }
        public string Observacion { get; set; }
    }
}
