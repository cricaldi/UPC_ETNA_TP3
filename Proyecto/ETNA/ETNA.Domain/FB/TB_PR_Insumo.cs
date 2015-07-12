using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETNA.Domain
{
    public class TB_PR_Insumo
    {
        public string InsumoId { get; set; }
        public string Descripcion { get; set; }
        public int StockDispInsumo { get; set; }
        public int StockResInsumo { get; set; }
        public string Observacion { get; set; }
    }
}
