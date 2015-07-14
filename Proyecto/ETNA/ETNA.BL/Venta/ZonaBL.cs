using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL.Venta;

namespace ETNA.BL.Venta
{
    public class ZonaBL
    {

        ZonaDAO bl = new ZonaDAO();

        public DataTable getZonas(string str)
        {
            return bl.ObtenerZonas(str);
        }
    }
}
