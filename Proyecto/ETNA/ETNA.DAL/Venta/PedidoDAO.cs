using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class PedidoDAO
    {
        ProductosDAO prodao = new ProductosDAO();

        public  Boolean insertPedidoDetalle(PedidoBE be,DataTable dt)
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
                                   "sp_vt_insertpedido";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter OutputParam = new SqlParameter("@CodCodigo", SqlDbType.Int);
                    OutputParam.Direction = ParameterDirection.Output;command.Parameters.Add(OutputParam);
                    
                    command.Parameters.Add(
              new SqlParameter("@IDcliente", be.IDCliente));
                    command.Parameters.Add(
              new SqlParameter("@fechaemision", be.FechaEmision));
                    command.Parameters.Add(
              new SqlParameter("@fechaentrega", be.FechaEntrega));
                    command.Parameters.Add(
              new SqlParameter("@idmoddalidadcredito", be.IDModalidadCredito));
                    command.Parameters.Add(
              new SqlParameter("@fechapago", be.FechaPago));
                          command.Parameters.Add(
              new SqlParameter("@credito", be.Credito));
                          command.Parameters.Add(
              new SqlParameter("@direccion", be.Direccion));
                          command.Parameters.Add(
              new SqlParameter("@idvendedor", be.IDVendedor));
                          command.Parameters.Add(
              new SqlParameter("@observacion", be.Observacion));
                          command.Parameters.Add(
              new SqlParameter("@precioincluyeim", be.PrecioIncluyeImpuesto));
                          command.Parameters.Add(
              new SqlParameter("@estadofactura", be.EstadoFacturacion));
                          command.Parameters.Add(
              new SqlParameter("@direccionentrega", be.DireccionEntrega));

                          command.Parameters.Add(
                   new SqlParameter("@estadoAprobacion", be.EstadoAprobacion));
                          command.Parameters.Add(
                   new SqlParameter("@codmoneda", be.CodMoneda));
                          command.Parameters.Add(
                   new SqlParameter("@codalmacen", be.CodAlmacen));

                    command.ExecuteNonQuery();



                    int codigo = int.Parse(command.Parameters["@CodCodigo"].Value.ToString());

                    if (codigo == 0)
                    {
                        codigo = 1;}

  

                    /*EL DETALLE*/

                    foreach (DataRow row in dt.Rows)
                {
                    command.CommandText = "sp_vt_insertdetpedido";

                    command.CommandType = CommandType.StoredProcedure;

                    String stridproducto = (row[0].ToString());

                    int codigoperu = prodao.ObtenerCodigoIDProducto(stridproducto);
                         

                    double cantidad = double.Parse(row[3].ToString());
                    double precio = double.Parse(row[2].ToString()); 
  
                        command.Parameters.Clear();
           command.Parameters.Add(
          new SqlParameter("@idproducto", codigoperu ));
                    command.Parameters.Add(
          new SqlParameter("@cantidad", cantidad));
                    command.Parameters.Add(
         new SqlParameter("@precio", precio));
                    command.Parameters.Add(
          new SqlParameter("@observacion", "BLABLABLA"));
                    command.Parameters.Add(
          new SqlParameter("@IdPedido", codigo));

                    command.Parameters.Add(
     new SqlParameter("@ListaPrecioId", 1));
                        

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


        public Boolean DELETEPEDIDOS(int codigo)
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
                                 "sp_vt_deletepedido";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
              new SqlParameter("@codigo", codigo));

                    command.ExecuteNonQuery();


                    // Attempt to commit the transaction.
                    transaction.Commit();

                    return true;

                }
                catch (Exception)
                {
                    return false;
                   
                }




            }

            return true;
        }
 


        public DataTable getpedidos(string strfiltro)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getpedidos";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;
            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", strfiltro));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }



        public DataTable getpedidos_vendedor(string codven,DateTime fec)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getpedidos_vendedor";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;
            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@filtro", codven));

            cmd.Parameters.Add(
              new SqlParameter("@fec", fec));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }


        public PedidoBE getPedido(int id)
            {
            PedidoBE be = new PedidoBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_getpedido";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;


            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@codpedido", id));



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (object.ReferenceEquals(dr["PedidoId"], DBNull.Value))
                    {
                        be.PKID = 0;
                    }
                    else
                    {
                        be.PKID = int.Parse(dr["PedidoId"].ToString());
                    }


                     if (object.ReferenceEquals(dr["ClienteId"], DBNull.Value))
                    {
                        be.IDCliente = 0;
                    }
                    else
                    {
                        be.IDCliente = int.Parse(dr["ClienteId"].ToString());
                    }



                     if (object.ReferenceEquals(dr["FechaEmision"], DBNull.Value))
                    {
                       
                    }
                    else
                     {
                         be.FechaEmision = DateTime.Parse((dr["FechaEmision"].ToString()));
                     }



                     if (object.ReferenceEquals(dr["FechaEntrega"], DBNull.Value))
                    {
                      
                    }
                    else
                    {
                        be.FechaEntrega = DateTime.Parse((dr["FechaEntrega"].ToString()));
                    }


                     if (object.ReferenceEquals(dr["ModalidadCreditoId"], DBNull.Value))
                    {
                       // be.IDModalidadCredito = 0;
                    }
                    else
                    {
                        be.IDModalidadCredito = int.Parse(dr["ModalidadCreditoId"].ToString());
                    }



                     if (object.ReferenceEquals(dr["FechaPago"], DBNull.Value))
                    {
                        //be. = 0;
                    }
                    else
                    {
                        be.FechaPago = DateTime.Parse(dr["FechaPago"].ToString());
                    }


                     if (object.ReferenceEquals(dr["Credito"], DBNull.Value))
                    {
                       // be.Credito = true;
                    }
                    else
                    {
                        be.Credito = Boolean.Parse(dr["Credito"].ToString());
                    }



                     if (object.ReferenceEquals(dr["Direccion"], DBNull.Value))
                    {
                        be.Direccion = "";
                    }
                    else
                    {
                        be.Direccion = dr["Direccion"].ToString();
                    }



                     if (object.ReferenceEquals(dr["IdVendedor"], DBNull.Value))
                    {
                        be.IDVendedor = 0;
                    }
                    else
                    {
                        be.IDVendedor = int.Parse(dr["IdVendedor"].ToString());
                    }


                     if (object.ReferenceEquals(dr["MonedaId"], DBNull.Value))
                     {
                         be.CodMoneda = 0;
                     }
                     else
                     {
                         be.CodMoneda = int.Parse(dr["MonedaId"].ToString());
                     }



                     if (object.ReferenceEquals(dr["AlmacenId"], DBNull.Value))
                     {
                         be.CodAlmacen = 0;
                     }
                     else
                     {
                         be.CodAlmacen = int.Parse(dr["AlmacenId"].ToString());
                     }





                     if (object.ReferenceEquals(dr["Observacion"], DBNull.Value))
                    {
                        be.Observacion = "";
                    }
                    else
                    {
                        be.Observacion = dr["Observacion"].ToString();
                    }


                     if (object.ReferenceEquals(dr["PrecioIncluyeImpuesto"], DBNull.Value))
                    {
                        //be.PrecioIncluyeImpuesto = 0;
                    }
                    else
                    {
                        be.PrecioIncluyeImpuesto = Boolean.Parse(dr["PrecioIncluyeImpuesto"].ToString());
                    }


                     if (object.ReferenceEquals(dr["EstadoFacturacion"], DBNull.Value))
                    {
                        be.EstadoFacturacion = "";
                    }
                    else
                    {
                        be.EstadoFacturacion = dr["EstadoFacturacion"].ToString();
                    }



                     if (object.ReferenceEquals(dr["DireccionEntrega"], DBNull.Value))
                    {
                        be.DireccionEntrega = "";
                    }
                    else
                    {
                        be.DireccionEntrega = dr["DireccionEntrega"].ToString();
                    }









                }
            }


            return be;

            }


        public DataTable obtenerDetalledPedidos(int codpedido)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getdetalllepedido";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@codpedido", codpedido));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }



        public DataTable obtenerDetalledPedidos_completo(int codpedido)

        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getdetalllepedidos_completo";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@codpedido", codpedido));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }

        public Boolean updatedetallepedido(int codigodetallepedido,double cant)
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
                                 "sp_vt_updetallepedido";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
              new SqlParameter("@coddetallepedidoid", codigodetallepedido));
                    command.Parameters.Add(
                                  new SqlParameter("@cantidad", cant));

                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return true;

                }
                catch (Exception)
                {
                    return false;

                }




            }

            return true;
        }




        public Boolean updateestadopedido(int codpedido,string strestado)
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
                                 "sp_vt_uppedidoestado";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
              new SqlParameter("@pedidoid", codpedido));
                    command.Parameters.Add(
                                  new SqlParameter("@estado", strestado));

                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    return true;

                }
                catch (Exception)
                {
                    return false;

                }




            }

            return true;
        }


        public Boolean insertDetallePedido(PedidoDetalleBE be) {

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
                                 "sp_vt_insertdetpedido";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Clear();
                    command.Parameters.Add(
                   new SqlParameter("@idproducto", be.idproducto));
                    command.Parameters.Add(
          new SqlParameter("@cantidad", be.cantidad));
                    command.Parameters.Add(
         new SqlParameter("@precio", be.total));
                    command.Parameters.Add(
          new SqlParameter("@observacion", be.observacion));
                    command.Parameters.Add(
          new SqlParameter("@IdPedido", be.IdPedido));


                    command.Parameters.Add(
     new SqlParameter("@ListaPrecioId", 1));
                        

                  
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();

                    return true;

                }
                catch (Exception)
                {
                    return false;

                }




            }

            return true;
            }

        public Boolean deletedetallepedido(int codigodetallepedido)
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
                                 "sp_vt_deletedetallepedido";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
              new SqlParameter("@detallepedidoid", codigodetallepedido));
                  
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();

                    return true;

                }
                catch (Exception)
                {
                    return false;

                }




            }

            return true;
        }


        public Boolean updtpedido(int codigopedido,int codigocli ,DateTime fecemisiom,DateTime fecentrega)
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
                                 "sp_vt_uppedido";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
              new SqlParameter("@codpedido", codigopedido));

                    command.Parameters.Add(
          new SqlParameter("@codigocli", codigocli));

                    command.Parameters.Add(
          new SqlParameter("@fechaemision", fecemisiom));

                    command.Parameters.Add(
          new SqlParameter("@fecaentrega", fecentrega));

                    command.ExecuteNonQuery();


                    // Attempt to commit the transaction.
                    transaction.Commit();

                    return true;

                }
                catch (Exception)
                {
                    return false;

                }




            }

            return true;
        }

        



 






    }
}

