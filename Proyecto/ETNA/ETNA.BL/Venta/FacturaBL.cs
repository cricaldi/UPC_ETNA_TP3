using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL.Venta;
using ETNA.Domain.Venta;

namespace ETNA.BL.Venta
{
    public class FacturaBL
    {
        FacturaDAO pd = new FacturaDAO();




        public Boolean insertPedido(FacturaBE be, DataTable dt)
        {
            return pd.insertFacturaDetalle(be, dt);
        }
        public Boolean insertFacturaDetalleXLote(FacturaBE be, DataTable dt)
        
        {
            return pd.insertFacturaDetalleXLote(be, dt);
        }


        

        public Boolean deletepedido(int codigo)
        {
            return pd.DELETEFacturas(codigo);
        }

        public Boolean uptpedido(int codigopedido, int concliente, DateTime fecemision, DateTime fecentrega)
        {
            return pd.updtfactura(codigopedido, concliente, fecemision, fecentrega);
        }



        public DataTable getpedidos(string strfiltro)
        {
            return pd.getFacturas(strfiltro);
        }


        public FacturaBE getpedido(int cod)
        {
            return pd.getFactura(cod);
        }

        public DataTable getdetallepedido(int cod)
        {
            return pd.obtenerDetalledFacturas(cod);
        }


        public Boolean deldetallepedido(int cod)
        {
            return pd.deletedetallefactura(cod);
        }

        public Boolean updetallepedido(int cod, double d)
        {
            return pd.updatedetallefactura(cod, d);
        }

        public Boolean inserdetpedido(PedidoDetalleBE be)
        {
            return pd.insertDetalleFactura(be);
        }

                   
    }
}
