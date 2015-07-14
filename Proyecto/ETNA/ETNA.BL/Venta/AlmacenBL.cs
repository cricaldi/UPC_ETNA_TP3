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
    public class AlmacenBL
    {
        AlmacenesDAO almdao = new AlmacenesDAO();
        public DataTable ObtenerAlmacenes()
        {

            return almdao.ObtenerAlmacenes();
        }

        public DataTable ObtenerAlmacenesfiltro(string filtro)
        {

            return almdao.obteneralmacenesFiltro(filtro);
        }


        public AlmacenBE getalmacen(int cod)
        {

            return almdao.getalmacen(cod);
        }


    }
}
