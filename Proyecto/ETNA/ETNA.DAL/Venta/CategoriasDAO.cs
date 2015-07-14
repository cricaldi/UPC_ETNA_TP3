using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace ETNA.DAL.Venta
{
    public class CategoriasDAO
    {

        public static DataTable ObtenerCategoria()
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "select categoriaid as PKID, Descripcion from tb_vt_Categoria;";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

    }
}
