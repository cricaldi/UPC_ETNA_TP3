using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ETNA.Domain.Venta;

namespace ETNA.DAL.Venta
{
    public class ClientesDAO
    {

        public ClienteBE getcliente(int clienteid)
        {
            ClienteBE be = new ClienteBE();

            SqlConnection con = DConexion.obtenerBD();



            string textoCmd = "sp_vt_getcliente";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;


            // 3. add parameter to command, which
            // will be passed to the stored procedure
            cmd.Parameters.Add(
                new SqlParameter("@CLIENTEID", clienteid));
          



            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (object.ReferenceEquals(dr["ClienteId"], DBNull.Value))
                    {
                        be.IdCliente = 0;
                    }
                    else
                    {
                        be.IdCliente = int.Parse(dr["ClienteId"].ToString());
                    }


                    if (object.ReferenceEquals(dr["codigo"], DBNull.Value))
                    {
                        be.Codigo = null;
                    }
                    else
                    {
                        be.Codigo = dr["codigo"].ToString();
                    }


                    if (object.ReferenceEquals(dr["Nombre"], DBNull.Value))
                    {
                        be.Nombre = null;
                    }
                    else
                    {
                        be.Nombre = dr["Nombre"].ToString();
                    }


                    if (object.ReferenceEquals(dr["CodigoModalidad"], DBNull.Value))
                    {
                        be.IDModalidadCredito = 0;
                    }
                    else
                    {
                        be.IDModalidadCredito = int.Parse(dr["CodigoModalidad"].ToString());
                    }


                    if (object.ReferenceEquals(dr["LineaCredito"], DBNull.Value))
                    {
                        be.LineaCredito = 0;
                    }
                    else
                    {
                        be.LineaCredito = Decimal.Parse(dr["LineaCredito"].ToString());
                    }











                }
            }



            return be;

        }


        public  DataTable ObtenerClientes()
        {

            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_get_clientes";
            
            SqlCommand cmd = new SqlCommand(textoCmd, con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);

            return datos;

        }


        public DataTable obtenerclientesFiltro(string filtro)
        {
            SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "sp_vt_get_clientes_filtro";

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

        /*
            // Cargar clientes
             SqlConnection con = DConexion.obtenerBD();

            DataTable datos = new DataTable();

            string textoCmd = "select a.codigo, trim(a.primernombre)+' '+trim(a.apellidopaterno) nombre, (select b.descripcion from direccion b where a.idcliente = b.idcliente) direccion, a.docidentidad from cliente a;";

            SqlCommand cmd = new SqlCommand(textoCmd, con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);
            DataGridView1.DataSource = datos;

            con.Close();
         */

    }
}
