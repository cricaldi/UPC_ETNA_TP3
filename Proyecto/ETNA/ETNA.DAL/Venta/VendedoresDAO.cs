using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class VendedoresDAO
    {

        public  DataTable ObtenerVendedores(string str)
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_empleados";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", str));
     

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }




        public EmpleadosBE getempleado(int codemp)
        {
            EmpleadosBE be = new EmpleadosBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_empleado";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;


            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@empleadoid", codemp));




            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (object.ReferenceEquals(dr["IdVendedor"], DBNull.Value))
                    {
                        be.Id = 0;
                    }
                    else
                    {
                        be.Id = int.Parse(dr["IdVendedor"].ToString());
                    }


                    if (object.ReferenceEquals(dr["nombres"], DBNull.Value))
                    {
                        be.Nombres = null;
                    }   
                    else
                    {
                        be.Nombres = dr["nombres"].ToString();
                    }




                }
            }



            return be;

        }



    }
}
