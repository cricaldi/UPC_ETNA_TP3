using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class AlmacenesDAO
    {

        public  DataTable ObtenerAlmacenes()
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getalmacenes";

            SqlCommand cmd = new SqlCommand(textoCmd, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

        public DataTable obteneralmacenesFiltro(string filtro)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getalmacenesfiltro";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", filtro));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }


        public AlmacenBE getalmacen(int codemp)
        {
            AlmacenBE be = new AlmacenBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_almacen";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;


            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@codalmacen", codemp));




            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (object.ReferenceEquals(dr["AlmacenId"], DBNull.Value))
                    {
                        be.AlmacenId = 0;
                    }
                    else
                    {
                        be.AlmacenId = int.Parse(dr["AlmacenId"].ToString());
                    }


                    if (object.ReferenceEquals(dr["Nombre"], DBNull.Value))
                    {
                        be.Nombre = null;
                    }
                    else
                    {
                        be.Nombre = dr["Nombre"].ToString();
                    }




                }
            }



            return be;

        }



    }
}
