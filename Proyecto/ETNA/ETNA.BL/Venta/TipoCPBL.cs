using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ETNA.DAL.Venta;
using ETNA.Domain.Venta;

namespace ETNA.BL.Venta
{
    public class TipoCPBL
    {

        TipoCPDAO t = new TipoCPDAO();


        public DataTable gettipocp()
        {
            return t.ObtenerAlmacenes();
        }

    }
}
