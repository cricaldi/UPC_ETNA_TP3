using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETNA.Domain.Venta;
using ETNA.DAL.Venta;

namespace ETNA.BL.Venta
{
    public class DireccionBL
    {

        DireccionDAO d = new DireccionDAO();

        public DataTable getdirecciones(int cod,string str)

        {
            return d.ObtenerDireccion(cod, str);
        }

        public DireccionBE getdireccion(int cod)
        {
            return d.getdireccion(cod);
        }
    }
}
