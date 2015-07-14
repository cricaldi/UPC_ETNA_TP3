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
    public class VendedorBL
    {
        VendedoresDAO v = new VendedoresDAO();

        public DataTable getvendedores(string fil)
        {
            return v.ObtenerVendedores(fil);
        }


        public EmpleadosBE getvendedor(int cod)
        {
            return v.getempleado(cod);
        }
    }
}
