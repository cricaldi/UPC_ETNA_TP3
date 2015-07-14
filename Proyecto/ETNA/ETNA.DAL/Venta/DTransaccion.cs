using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Data.SqlClient;
using System.Data;

using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class DTransaccion
    {

       /* DConexion cn = new DConexion();

        public int DInsertCabPed(PedidoCabecera  PedCab)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO Pedido (PKID, IDCliente, FechaEmision, FechaEntrega, IDModalidadCredito, FechaPago, Credito, Direccion, IDVendedor, Observacion, PrecioIncluyeImpuesto, EstadoFacturacion, DireccionEntrega) " +
                " VALUES (" + PedCab.PKID + ", " + PedCab.IDCliente + ", '" + PedCab.FechaEmision + "', " +
                " '" + PedCab.FechaEntrega + "', '" + PedCab.IDModalidadCredito + "', " + PedCab.FechaPago + ", " +
                " " + PedCab.Credito + ", " + PedCab.Direccion + ", '" + PedCab.IDVendedor + "', '" + PedCab.Observacion +
                " " + PedCab.PrecioIncluyeImpuesto + ", " + PedCab.EstadoFacturacion + ", '" + PedCab.DireccionEntrega + "')";
                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

        public int DInsertDetPed(PedidoDetalle  PedDet)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                string sql = "INSERT INTO dbo.detallepedido ( idproducto, cantidad, total, observacion) " +
                    " VALUES (" + PedDet.idproducto + ", " + PedDet.cantidad + ", " + PedDet.total + ", " + PedDet.observacion + ")";
                cmd.CommandText = sql;
                cmd.Connection = cn.Conectar;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                i = 1;
                cmd.Dispose();
                cn.Conectar.Dispose();
                cn.Conectar.Close();
            }
            catch { throw; }
            return i;
        }

*/
    
    }
}
