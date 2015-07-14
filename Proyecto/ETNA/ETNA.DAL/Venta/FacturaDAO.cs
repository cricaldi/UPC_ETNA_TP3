using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.Domain.Venta;
using ETNA.DAL.Venta;

namespace ETNA.DAL.Venta
{
    public class FacturaDAO
    {

         ProductosDAO prodao = new ProductosDAO();
        public Boolean insertFacturaDetalle(FacturaBE be, DataTable dt)
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
                                   "sp_vt_insertcomprobaventa";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter OutputParam = new SqlParameter("@CodCodigo", SqlDbType.Int);
                    OutputParam.Direction = ParameterDirection.Output; command.Parameters.Add(OutputParam);

                    command.Parameters.Add(
              new SqlParameter("@IDcliente", be.ClienteId));
                    command.Parameters.Add(
              new SqlParameter("@fechaemision", be.FechaEmision));
                    command.Parameters.Add(
              new SqlParameter("@fechaentrega", be.FechaEntrega));
                    command.Parameters.Add(
              new SqlParameter("@idmoddalidadcredito", be.ModalidadCreditoId));
                    command.Parameters.Add(
              new SqlParameter("@fechapago", be.FechaPago));
                    command.Parameters.Add(
        new SqlParameter("@credito", be.Credito));
                    command.Parameters.Add(
        new SqlParameter("@direccion", be.Direccion));
                    command.Parameters.Add(
        new SqlParameter("@idvendedor", be.IdVendedor));
                    command.Parameters.Add(
        new SqlParameter("@observacion", be.Observacion));
                    command.Parameters.Add(
        new SqlParameter("@precioincluyeim", be.PrecioIncluyeImpuesto));
                    command.Parameters.Add(
        new SqlParameter("@estadofactura", be.EstadoFacturacion));
                    command.Parameters.Add(
        new SqlParameter("@direccionentrega", be.DireccionEntrega));

                    command.Parameters.Add(
       new SqlParameter("@tipocp", be.TipoCP));
                    command.Parameters.Add(
             new SqlParameter("@estadoAprobacion", be.EstadoFacturacion));
             //       command.Parameters.Add(
             //new SqlParameter("@codmoneda", be.CodMoneda));
             //       command.Parameters.Add(
             //new SqlParameter("@codalmacen", be.CodAlmacen));

                    command.ExecuteNonQuery();



                    int codigo = int.Parse(command.Parameters["@CodCodigo"].Value.ToString());

                    if (codigo == 0)
                    {
                        codigo = 1;
                    }



                    /*EL DETALLE*/

                    foreach (DataRow row in dt.Rows)
                    {
                        command.CommandText = "sp_vt_insertdetfactu";

                        command.CommandType = CommandType.StoredProcedure;

                        String stridproducto = (row[0].ToString());

                        int codigoperu = prodao.ObtenerCodigoIDProducto(stridproducto);


                        double cantidad = double.Parse(row[3].ToString());
                        double precio = double.Parse(row[2].ToString());

                        command.Parameters.Clear();
                        command.Parameters.Add(
                       new SqlParameter("@idproducto", codigoperu));
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


        public Boolean insertFacturaDetalleXLote(FacturaBE be, DataTable dt)
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
                                   "sp_vt_insertcomprobaventa_porlote";
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter OutputParam = new SqlParameter("@CodCodigo", SqlDbType.Int);
                    OutputParam.Direction = ParameterDirection.Output; command.Parameters.Add(OutputParam);

                    command.Parameters.Add(
              new SqlParameter("@IDcliente", be.ClienteId));
                    command.Parameters.Add(
              new SqlParameter("@fechaemision", be.FechaEmision));
                    command.Parameters.Add(
              new SqlParameter("@fechaentrega", DateTime.Now));
                    command.Parameters.Add(
              new SqlParameter("@fecregistro", DateTime.Now));
                    command.Parameters.Add(
               new SqlParameter("@fecvencimiento", be.FechaEmision));
                    command.Parameters.Add(
              new SqlParameter("@idmoddalidadcredito", be.ModalidadCreditoId));
                    command.Parameters.Add(
              new SqlParameter("@fechapago", be.FechaPago));
                    command.Parameters.Add(
        new SqlParameter("@credito", be.Credito));
                    command.Parameters.Add(
        new SqlParameter("@direccion", be.Direccion));
                    command.Parameters.Add(
        new SqlParameter("@idvendedor", be.IdVendedor));
                    command.Parameters.Add(
        new SqlParameter("@observacion", be.Observacion));
                    command.Parameters.Add(
      new SqlParameter("@observaciones", be.Observaciones));
                    command.Parameters.Add(
        new SqlParameter("@precioincluyeim", be.PrecioIncluyeImpuesto));
           
                    command.Parameters.Add(
        new SqlParameter("@direccionentrega", be.DireccionEntrega));
                    command.Parameters.Add(
            new SqlParameter("@valorventa", decimal.Parse("0.0") ));
                    command.Parameters.Add(
          new SqlParameter("@subtotal", decimal.Parse("0.0")));
                    command.Parameters.Add(
          new SqlParameter("@montoigv", decimal.Parse("0.0")));
                    command.Parameters.Add(
         new SqlParameter("@total", decimal.Parse("0.0")));

                    command.Parameters.Add(
        new SqlParameter("@tipocp", be.TipoCP)  );

                 
    command.Parameters.Add(
             new SqlParameter("@estadoFacturacion", be.EstadoFacturacion));
  command.Parameters.Add(
             new SqlParameter("@codsolatencion", 1));
  command.Parameters.Add(
             new SqlParameter("@codreq", 1));
  command.Parameters.Add(
             new SqlParameter("@codformato", 1));



                    //       command.Parameters.Add(
                    //new SqlParameter("@codmoneda", be.CodMoneda));
                    //       command.Parameters.Add(
                    //new SqlParameter("@codalmacen", be.CodAlmacen));

                    command.ExecuteNonQuery();



                    int codigo = int.Parse(command.Parameters["@CodCodigo"].Value.ToString());

                    if (codigo == 0)
                    {
                        codigo = 1;
                    }



                    /*EL DETALLE*/

                    foreach (DataRow row in dt.Rows)
                    {
                        command.CommandText = "sp_vt_insertdetfactu";

                        command.CommandType = CommandType.StoredProcedure;

                        int stridproducto = int.Parse(row[0].ToString());

                       // int codigoperu = prodao.ObtenerCodigoIDProducto(stridproducto);


                        decimal cantidad = Convert.ToDecimal((row[1].ToString()));
                        decimal precio = Convert.ToDecimal(row[2].ToString());
                        String obs = row[3].ToString();

                        command.Parameters.Clear();
                        command.Parameters.Add(
                       new SqlParameter("@idproducto", stridproducto));
                        command.Parameters.Add(
              new SqlParameter("@cantidad", cantidad ));
                        command.Parameters.Add(
             new SqlParameter("@valortotal", precio));
                        command.Parameters.Add(
              new SqlParameter("@observacion", obs));
                        command.Parameters.Add(
              new SqlParameter("@IdFactura", codigo));
                        

                        command.Parameters.Add(
         new SqlParameter("@Codreq", 1));


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

        public Boolean DELETEFacturas(int codigo)
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
                                 "sp_vt_deletefactu";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
              new SqlParameter("@FacturaId", codigo));

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



        public DataTable getFacturas(string strfiltro)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getfacturas";

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



        public FacturaBE getFactura(int id)
        {
            FacturaBE be = new FacturaBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_getfactura";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;


            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@codfactu", id));



            SqlDataReader dr = cmd.ExecuteReader();

           
             if (dr.HasRows) {
			while (dr.Read()) {
				
				if (object.ReferenceEquals(dr["FacturaId"], DBNull.Value)) {
					be.FacturaId = 0;
				} else {
					be.FacturaId = int.Parse( dr["FacturaId"].ToString());
				}

				if (object.ReferenceEquals(dr["NumeroFact"], DBNull.Value)) {
					be.NumeroFact = 0;
				} else {
					be.NumeroFact =  int.Parse( dr["NumeroFact"].ToString());
				}

				if (object.ReferenceEquals(dr["ClienteId"], DBNull.Value)) {
					be.ClienteId = 0;
				} else {
					be.ClienteId =  int.Parse(  dr["ClienteId"].ToString());
				}

				if (object.ReferenceEquals(dr["FechaEmision"], DBNull.Value)) {
					//be.FechaEmision = null;
				} else {
					be.FechaEmision = DateTime.Parse( dr["FechaEmision"].ToString() );
				}

				if (object.ReferenceEquals(dr["FechaEntrega"], DBNull.Value)) {
				//	be.FechaEntrega = null;
				} else {
					be.FechaEntrega = DateTime.Parse(  dr["FechaEntrega"] .ToString());
				}

				if (object.ReferenceEquals(dr["ModalidadCreditoId"], DBNull.Value)) {
					be.ModalidadCreditoId = 0;
				} else {
					be.ModalidadCreditoId = int.Parse( dr["ModalidadCreditoId"].ToString());
				}

				if (object.ReferenceEquals(dr["FechaPago"], DBNull.Value)) {
					//be.FechaPago = null;
				} else {
					be.FechaPago =  DateTime.Parse( dr["FechaPago"].ToString());
				}

				if (object.ReferenceEquals(dr["Credito"], DBNull.Value)) {
					//be.Credito = null;
				} else {
					be.Credito = Boolean.Parse( dr["Credito"].ToString());
				}

				if (object.ReferenceEquals(dr["Direccion"], DBNull.Value)) {
					be.Direccion = null;
				} else {
					be.Direccion = dr["Direccion"].ToString();
				}

				if (object.ReferenceEquals(dr["IdVendedor"], DBNull.Value)) {
					be.IdVendedor = 0;
				} else {
					be.IdVendedor = int.Parse( dr["IdVendedor"].ToString());
				}

				if (object.ReferenceEquals(dr["Observacion"], DBNull.Value)) {
					be.Observacion = null;
				} else {
					be.Observacion = dr["Observacion"].ToString();
				}

				if (object.ReferenceEquals(dr["ValorVenta"], DBNull.Value)) {
					be.ValorVenta = 0;
				} else {
					be.ValorVenta = double.Parse( dr["ValorVenta"].ToString());
				}

				if (object.ReferenceEquals(dr["PrecioIncluyeImpuesto"], DBNull.Value)) {
					//be.PrecioIncluyeImpuesto = 0;
				} else {
					be.PrecioIncluyeImpuesto =  Boolean.Parse( dr["PrecioIncluyeImpuesto"].ToString());
				}

				if (object.ReferenceEquals(dr["EstadoFacturacion"], DBNull.Value)) {
					be.EstadoFacturacion = null;
				} else {
					be.EstadoFacturacion = dr["EstadoFacturacion"].ToString();
				}

				if (object.ReferenceEquals(dr["DireccionEntrega"], DBNull.Value)) {
					be.DireccionEntrega = null;
				} else {
					be.DireccionEntrega = dr["DireccionEntrega"].ToString();
				}

				if (object.ReferenceEquals(dr["Subtotal"], DBNull.Value)) {
					be.Subtotal = 0;
				} else {
					be.Subtotal = Decimal.Parse( dr["Subtotal"].ToString());
				}

				if (object.ReferenceEquals(dr["MontoIGV"], DBNull.Value)) {
					//be.MontoIGV = null;
				} else {
					be.MontoIGV =  decimal.Parse( dr["MontoIGV"].ToString());
				}

				if (object.ReferenceEquals(dr["Total"], DBNull.Value)) {
					//be.Total = null;
				} else {
					be.Total =  Decimal.Parse( dr["Total"].ToString());
				}

				if (object.ReferenceEquals(dr["Observaciones"], DBNull.Value)) {
					be.Observaciones = null;
				} else {
					be.Observaciones = dr["Observaciones"].ToString();
				}

				if (object.ReferenceEquals(dr["FechaRegistro"], DBNull.Value)) {
					//be.FechaRegistro = null;
				} else {
					be.FechaRegistro = DateTime.Parse( dr["FechaRegistro"].ToString());
				}

				if (object.ReferenceEquals(dr["FechaVencimiento"], DBNull.Value)) {
					//be.FechaVencimiento = null;
				} else {
					be.FechaVencimiento = DateTime.Parse(  dr["FechaVencimiento"].ToString());
				}

				if (object.ReferenceEquals(dr["CodigoSolAtencion"], DBNull.Value)) {
					//be.CodigoSolAtencion = null;
				} else {
					be.CodigoSolAtencion = int.Parse( dr["CodigoSolAtencion"].ToString());
				}

				if (object.ReferenceEquals(dr["CodigoReq"], DBNull.Value)) {
					//be.CodigoReq = null;
				} else {
					be.CodigoReq = int.Parse( dr["CodigoReq"].ToString());
				}

				if (object.ReferenceEquals(dr["CodigoFormato"], DBNull.Value)) {
					//be.CodigoFormato = null;
				} else {
					be.CodigoFormato = int.Parse( dr["CodigoFormato"].ToString());
				}


            }
             }




            return be;

        }


        public DataTable obtenerDetalledFacturas(int codpedido)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_getdetalllefactu";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@factuid", codpedido));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }



        public Boolean updatedetallefactura(int codigodetallepedido, double cant)
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
                                 "sp_vt_updetallefactu";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(
              new SqlParameter("@codfactudetalle", codigodetallepedido));
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



        public Boolean insertDetalleFactura(PedidoDetalleBE be)
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

        public Boolean deletedetallefactura(int codigodetallepedido)
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


        public Boolean updtfactura(int codigopedido, int codigocli, DateTime fecemisiom, DateTime fecentrega)
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
