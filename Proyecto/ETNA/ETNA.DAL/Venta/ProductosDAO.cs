using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class ProductosDAO
    {

        public  DataTable ObtenerProductos()
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getproductos";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

        public int ObtenerCodigoIDProducto(string strcodigo)
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getcodigoIDproducto";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter OutputParam = new SqlParameter("@CodCodigo", SqlDbType.Int);
            OutputParam.Direction = ParameterDirection.Output; cmd.Parameters.Add(OutputParam);


            cmd.Parameters.Add(
             new SqlParameter("@codproducto", strcodigo));

            cmd.ExecuteNonQuery();

            int codigo = int.Parse(cmd.Parameters["@CodCodigo"].Value.ToString());

            return codigo;

        }

        public  DataTable ObtenerProductosFiltro(String pFiltro)
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_ve_getproductoxfiltro";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", pFiltro));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

    }
}
