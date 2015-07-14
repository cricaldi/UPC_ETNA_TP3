using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Windows.Forms;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class DireccionDAO
    {

        public  DataTable ObtenerDireccion(int codiddir , string desc)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_direcciones";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", codiddir));  
            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@desc", desc));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }



        public DireccionBE getdireccion(int cod)
        {
            DireccionBE be = new DireccionBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_getdireccion";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;


            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@cod", cod));




            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (object.ReferenceEquals(dr["DireccionId"], DBNull.Value))
                    {
                        be.DireccionId = 0;
                    }
                    else
                    {
                        be.DireccionId = int.Parse(dr["DireccionId"].ToString());
                    }


                    if (object.ReferenceEquals(dr["Descripcion"], DBNull.Value))
                    {
                        be.Descripcion = null;
                    }
                    else
                    {
                        be.Descripcion = dr["Descripcion"].ToString();
                    }




                }
            }



            return be;

        }


    }
}
