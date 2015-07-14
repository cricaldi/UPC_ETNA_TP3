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
    public class CuentaVentaBL
    {
        CuotaVentaDAO cbl = new CuotaVentaDAO();

        public Boolean insertcuentaventadet(CuentaVentaBE be , DataTable dt)
        {
            return cbl.insertPedidoDetalle(be, dt);
        }


        public DataTable getcuentasventas(int anio)
        {
            return cbl.obtenerCuentaVenta(anio);
        }
    }
}
