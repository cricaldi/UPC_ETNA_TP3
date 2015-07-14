using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.SGI.Data;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
   public class AutenticacionDAO
    {
        public  EmpleadosBE Autenticacion(string usu , string pass)
        {
            EmpleadosBE be = new EmpleadosBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_autenticacion";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;
            

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@usu", usu));
            cmd.Parameters.Add(
              new SqlParameter("@pass", pass));



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (object.ReferenceEquals(dr["id"], DBNull.Value))
                    {
                        be.Id = 0;
                    }
                    else
                    {
                        be.Id = int.Parse(dr["id"].ToString()) ;
                    }


                    if (object.ReferenceEquals(dr["cargo"], DBNull.Value))
                    {
                        be.Cargo = null;
                    }
                    else
                    {
                        be.Cargo = dr["cargo"].ToString();
                    }


                    if (object.ReferenceEquals(dr["apellidos"], DBNull.Value))
                    {
                        be.Apellidos = null;
                    }
                    else
                    {
                        be.Apellidos = dr["apellidos"].ToString();
                    }


                          if (object.ReferenceEquals(dr["nombres"], DBNull.Value))
                    {
                        be.Nombres = null;
                    }
                    else
                    {
                        be.Nombres = dr["nombres"].ToString();
                    }


                          if (object.ReferenceEquals(dr["userprofile_userid"], DBNull.Value))
                    {
                        be.UserProfile_UserId = 0;
                    }
                    else
                    {
                        be.UserProfile_UserId = int.Parse( dr["userprofile_userid"].ToString());
                    }





                    




                }
            }

        

            return be;
    
        }
    }
}
