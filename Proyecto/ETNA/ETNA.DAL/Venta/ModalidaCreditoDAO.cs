using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class ModalidaCreditoDAO
    {

        public ModalidadCreditoBE getmodalidad(int cod)
        {
            ModalidadCreditoBE be = new ModalidadCreditoBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_getmodalidadcredit";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;


            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@codigo", cod));




            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (object.ReferenceEquals(dr["ModalidadCreditoID"], DBNull.Value))
                    {
                        be.ModalidadCreditoId = 0;
                    }
                    else
                    {
                        be.ModalidadCreditoId = int.Parse(dr["ModalidadCreditoID"].ToString());
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
