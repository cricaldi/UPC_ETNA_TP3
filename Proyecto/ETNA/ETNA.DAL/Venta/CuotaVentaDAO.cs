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
    public class CuotaVentaDAO
    {

        public Boolean insertPedidoDetalle(CuentaVentaBE be, DataTable dtdetalle)
        {

            String con = appventa.Default.Setting;


            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;


                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection 
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                                   "sp_vt_insertcuotavent";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter OutputParam = new SqlParameter("@CodCodigo", SqlDbType.Int);
                    OutputParam.Direction = ParameterDirection.Output; command.Parameters.Add(OutputParam);

                    command.Parameters.Add(
              new SqlParameter("@mes", be.Mes));
               
                    command.Parameters.Add(
              new SqlParameter("@anio", be.Año));
                    command.Parameters.Add(
              new SqlParameter("@dias_habiles", be.Dias_Habiles));
                    command.Parameters.Add(
              new SqlParameter("@monto_cuota", be.Monto_Cuota));
                    command.ExecuteNonQuery();



                    int codigo = int.Parse(command.Parameters["@CodCodigo"].Value.ToString());

                    if (codigo == 0)
                    {
                        codigo = 1;
                    }



                    /*EL DETALLE*/

                    foreach (DataRow row in dtdetalle.Rows)
                    {
                        command.CommandText = "sp_vt_insertcuotaventadet";

                        command.CommandType = CommandType.StoredProcedure;

                        //int cuotaid = int.Parse (row[0].ToString());
                        int producid = int.Parse(row[1].ToString());
                        int idvendedor = int.Parse(row[2].ToString());
                        int zonaid = int.Parse(row[3].ToString());
                        double cuota = double.Parse(row[4].ToString());

                  

                        command.Parameters.Clear();
                   
                        command.Parameters.Add(
              new SqlParameter("@cuotaid", codigo));
                        command.Parameters.Add(
             new SqlParameter("@productoid", producid));
                        command.Parameters.Add(
              new SqlParameter("@idvendedor", idvendedor));
                        command.Parameters.Add(
              new SqlParameter("@zonaid", zonaid));

                        command.Parameters.Add(
         new SqlParameter("@cuota", cuota));


                        command.ExecuteNonQuery();
                    }




                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");

                    return true;
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception ex2)
                    {
                        return false;


                        // This catch block will handle any errors that may have occurred 
                        // on the server that would cause the rollback to fail, such as 
                        // a closed connection.
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                }
            }
        }

        //sp_vt_validaempxperioxzona

        public DataTable obtenerCuentaVenta(int anio)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getcuotaventas";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@anio", anio));
            // 3. add parameter to command, which
            // will be passed to the stored procedure
          

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

        public  int validar_emplead_existe_con_periodo_zona(int strperiodo,int stranio,int strempleadoid)
        {


            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_validaempxperioxzona";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter OutputParam = new SqlParameter("@CodCodigo", SqlDbType.Int);
            OutputParam.Direction = ParameterDirection.Output; cmd.Parameters.Add(OutputParam);

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@periodo", strperiodo)); 
            cmd.Parameters.Add(
                new SqlParameter("@anio", stranio)); 
            cmd.Parameters.Add(
                new SqlParameter("@empleadoid", strempleadoid));

            cmd.Parameters.Add(
                          new SqlParameter("@CodCodigo", 0));


            cmd.ExecuteNonQuery();



            int codigo = int.Parse(cmd.Parameters["@CodCodigo"].Value.ToString());

            return codigo;



        }

    }
}
