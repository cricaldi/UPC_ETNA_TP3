using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ETNA.Domain.Venta;
using ETNA.BL.Venta;

namespace ETNA.SGI.Presentacion.Venta
{
    public partial class frmConsultarProducto : DevExpress.XtraEditors.XtraForm
    {
        frmPedido frmpedido;
        frmUpPedido frmuppedido;
        frmCuotaVenta frmCuotaVenta;
        frmComprobanteVenta frmComprobanteVenta;

        public String origen = "";
        public String gstrvende = "";
        ProductoBL pb = new ProductoBL();
        PedidoDetalleBE ped = new PedidoDetalleBE();
        PedidoBL blped = new PedidoBL();

        public frmConsultarProducto(frmPedido frm)
        {
            InitializeComponent();

            this.frmpedido = frm;
            origen = frm.Name;
            dataGridView1.DataSource = pb.ObtenerProductos();
            dataGridView1.AllowUserToAddRows = false;

        }

        public frmConsultarProducto(frmComprobanteVenta frm)
        {
            InitializeComponent();

            this.frmComprobanteVenta = frm;
            origen = frm.Name;
            dataGridView1.DataSource = pb.ObtenerProductos();
            dataGridView1.AllowUserToAddRows = false;

        }

        public frmConsultarProducto(frmCuotaVenta frm, String strvende)
        {
            InitializeComponent();

            this.frmCuotaVenta = frm;
            origen = frm.Name;
            gstrvende = strvende;
            dataGridView1.DataSource = pb.ObtenerProductos();
            dataGridView1.AllowUserToAddRows = false;

        }

        public frmConsultarProducto(frmUpPedido frm)
        {
            InitializeComponent();

            this.frmuppedido = frm;

            origen = frm.Name;
            dataGridView1.DataSource = pb.ObtenerProductos();
            dataGridView1.AllowUserToAddRows = false;

        }






        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          Boolean modificado = false;
            string codigo = this.dataGridView1.SelectedCells[0].Value.ToString();
            
            if (origen == "frmUpPedido")
            {


                if (frmuppedido.dtdetalle.Rows.Count >= 1)
                {

                    int cantidadnueva = 0;
                    foreach (DataRow row in frmuppedido.dtdetalle.Rows)
                    {
                        string codigodetalle = row[0].ToString();
                        if (codigodetalle == codigo)
                        {
                            int pedidodetalle = int.Parse(row[4].ToString());

                            Double cantidad = Double.Parse(row[3].ToString());
                            int cantidad2 = int.Parse(cantidad.ToString());

                            
                            row[3] = cantidad2 + 1;
                            if (blped.updetallepedido(pedidodetalle, int.Parse(row[3].ToString())))
                            {
                                MessageBox.Show(
                                    "Se agrego una cantidad detalle pedido debido a que el item que sea agregar ya existe");
                                modificado = true;

                            }
                            else
                            {

                                MessageBox.Show("No se pudo actualizar la cantidad, Comunicarse con el administrador del sistema");
                                this.Close();
                            }
                            
                           

                           
                            
                        //    row[3] = int.Parse(row[3].ToString()) + 1;
                        //    cantidadnueva = int.Parse(row[3].ToString());
                        //    modificado = true;
                        }

                     

                      





                    }



                    if (modificado == false)
                    {


                        int codigoProducto = pb.obteneridproducto(codigo);
                        decimal precio = decimal.Parse(this.dataGridView1.SelectedCells[2].Value.ToString());

                        PedidoDetalleBE pedidoDetalleBE = new PedidoDetalleBE();
                        pedidoDetalleBE.idproducto = codigoProducto;
                        pedidoDetalleBE.IdPedido = frmuppedido.ped.PKID;
                        pedidoDetalleBE.cantidad = 1;
                        pedidoDetalleBE.observacion ="Ingresado en la Modificacion del pedido" ;
                        pedidoDetalleBE.total = precio;

                        if (blped.inserdetpedido(pedidoDetalleBE))
                        {
                            MessageBox.Show(
                       "Se agrego una detalle al pedido");

                        }

                        //frmpedido.dtdetalle.Rows.Add(codigo,
                        //           this.dataGridView1.SelectedCells[1].Value.ToString(),
                        //           Double.Parse(this.dataGridView1.SelectedCells[2].Value.ToString()),
                        //           1);

                    }
                }
                 frmuppedido.actualizarDetalle();
                 frmuppedido.actualizarmontos();
                 this.Close();


            }
            else if (origen == "frmPedido")
            {

                if (frmpedido.dtdetalle.Rows.Count >= 1)
                {


                    foreach (DataRow row in frmpedido.dtdetalle.Rows)
                    {
                        String codigodetalle = row[0].ToString();
                        if (codigodetalle == codigo)
                        {
                            row[3] = int.Parse(row[3].ToString()) + 1;
                            modificado = true;
                        }

                    }

                }

                if (modificado == true)
                {
                    MessageBox.Show("Se Agregara una cantidad al producto");
                }
                else
                {
                    if (frmpedido.Name == "frmPedido")
                    {

                        frmpedido.dtdetalle.Rows.Add(codigo,
                                   this.dataGridView1.SelectedCells[1].Value.ToString(),
                                   Double.Parse(this.dataGridView1.SelectedCells[2].Value.ToString()),
                                   1);


                       
                        
                    }


              

                   }






                frmpedido.actualizarDetalle();
                frmpedido.actualizarmontos();



                
            } else if (origen == "frmCuotaVenta")
            {

            
                if (frmCuotaVenta.dtvendedor.Rows.Count >= 1)
                {
                    ProductoBL pbl= new ProductoBL();

                    foreach (DataRow row in frmCuotaVenta.dtproducto.Rows)
                    {
                        String codpro = row[0].ToString();
                        String codvend = row[2].ToString();

                        string codigoreal = pbl.obteneridproducto(codigo).ToString();
                        if ((codigoreal == codpro) && (gstrvende == codvend))
                        {
                            
                            modificado = true;
                        }

                    }

                        if (modificado)
                        {
                            MessageBox.Show("Producto ya agregado para el vendedor");
                            this.Close();
                        }else
                        {
                           
                            int uid = pbl.obteneridproducto(codigo);

                            frmCuotaVenta.dtproducto.Rows.Add(uid,
                                this.dataGridView1.SelectedCells[1].Value.ToString(),
                                gstrvende,0);


                            frmCuotaVenta.actualizaProductos(gstrvende);
                            this.Close();
                           
                        }



                   

                }

                
            }

            this.Close();
          //     this.Close();
           

         
            
           
            //frmpedido.dtgDetalleProd.DataSource = null;
            //frmpedido.dtgDetalleProd.DataSource = frmpedido.dtDetPedido;

            //foreach (DataGridViewRow row in frmpedido.dtgDetalleProd.Rows) ;

           // double resultado = 0;
            //double total1 = 0;

            /*foreach (DataGridViewRow row in frmpedido.dtgDetalleProd.Rows)
            {
                resultado = (Convert.ToDouble(row.Cells["preciounitario"].Value) * Convert.ToDouble(row.Cells["cantidad"].Value));
                row.Cells["total"].Value = resultado;
                total1 += Convert.ToDouble(row.Cells["total"].Value);

                frmpedido.txtafecto.Text = Convert.ToString(total1);
                frmpedido.txtimpuesto.Text = Convert.ToString(total1 * 0.18);
                frmpedido.txttotal.Text = Convert.ToString((total1 * 0.18) + total1);



            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pb.ObtenerProductosFiltro(textBox2.Text);
                textBox2.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = pb.ObtenerProductosFiltro(textBox2.Text);
                textBox2.Text = "";
            }


        }

        private void frmConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pb.ObtenerProductosFiltro(textBox2.Text);
            textBox2.Text = "";
        }

       }
}
