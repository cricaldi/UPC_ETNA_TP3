using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ETNA.BL.PV;
using ETNA.BL.Venta;
using ETNA.Domain.Venta;

namespace ETNA.SGI.Presentacion.Venta
{
    public partial class frmFacturacionenLote : DevExpress.XtraEditors.XtraForm
    {

        private Random _Random;

        private BackgroundWorker _BackgroundWorker;

            PedidoBL pbl = new PedidoBL();
        DataTable dtpedidos = new DataTable();
       public  VendedorBE strvendedor = new VendedorBE();
       DataTable dtdetallefactura = new DataTable();
       DataTable dtdetallesfacturarel = new DataTable();
        public frmFacturacionenLote()
        {
            InitializeComponent();
            //progressBar1.Style = ProgressBarStyle.Marquee;
            //progressBar1.Visible = false;
            //_Random = new Random();

            //InitializeBackgroundWorker();

            dtpedidos = pbl.getpedidos_vendedor("",dateTimePicker1.Value);

            //dtpedidos.Columns.Add("item", typeof(Boolean));
            //dtpedidos.Columns.Add("Codigopedido", typeof(String));
            //dtpedidos.Columns.Add("nombre", typeof(String));
            //dtpedidos.Columns.Add("observacion", typeof(String));
            //dtpedidos.Columns.Add("vendedor", typeof(String));
            //dtpedidos.Columns.Add("codtipodocumento", typeof(String));
            //dtpedidos.Columns.Add("tipodocumento", typeof(String));
            //dtpedidos.Columns.Add("Monto", typeof(Double));
            //dtpedidos.Columns.Add("EstadoFacturacion", typeof(Int32));
            actualizardetalle(false);
            construirDetallefactura(dtdetallesfacturarel);
            construirDetallefactura(dtdetallefactura);
            dataGridView1.AllowUserToAddRows = false;


        }

        void actualizardetalle(Boolean data)
        {
            dataGridView1.Rows.Clear();
            if (dtpedidos.Rows.Count >= 1)
            {
                foreach (DataRow row in dtpedidos.Rows)
                {

                    dataGridView1.Rows.Add(data, row[0].ToString(), row[1].ToString(),
                        row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(),
                        row[6].ToString());


                }
            }

            
        }



        private void button1_Click(object sender, EventArgs e)
        {

            new frmConsultarVendedor(this).ShowDialog();
            dtpedidos = pbl.getpedidos_vendedor(strvendedor.IdVendedor.ToString(), dateTimePicker1.Value);
                actualizardetalle(false);

           
        }

        private void chkVen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVen.Checked == false)
            {
                txtFiltroVende.Visible = false;
                button1.Visible = false;
                txtFiltroVende.Text = "";
                strvendedor.IdVendedor = 0;
                if (strvendedor.IdVendedor == 0)
                {
                    dtpedidos = pbl.getpedidos_vendedor("", dateTimePicker1.Value);
                }

                actualizardetalle(false);
            }
            else
            {
                txtFiltroVende.Visible = true;
                button1.Visible = true;
                txtFiltroVende.Text = "";
                strvendedor.IdVendedor = 0;
                if (strvendedor.IdVendedor == 0)
                {
                    dtpedidos = pbl.getpedidos_vendedor("", dateTimePicker1.Value);
                }

                actualizardetalle(false);

            }
        }


        public void ACTUALIZARREGISTROS(){
            if (chkVen.Checked == false)
            {
                txtFiltroVende.Visible = false;
                button1.Visible = false;
                txtFiltroVende.Text = "";
                strvendedor.IdVendedor = 0;
                if (strvendedor.IdVendedor == 0)
                {
                    dtpedidos = pbl.getpedidos_vendedor("", dateTimePicker1.Value);
                }

                actualizardetalle(false);
            }
            else
            {
                txtFiltroVende.Visible = true;
                button1.Visible = true;
                txtFiltroVende.Text = "";
                strvendedor.IdVendedor = 0;
                if (strvendedor.IdVendedor == 0)
                {
                    dtpedidos = pbl.getpedidos_vendedor("", dateTimePicker1.Value);
                }

                actualizardetalle(false);

            }
        }


        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {

            if (dtpedidos.Rows.Count>0)
            {

                if (chkSelect.Checked == true)
                {
                    actualizardetalle(true);
                }
                else
                {
                    actualizardetalle(false);
                }
        
   
            }



        }

       /* void procesandoProgresabar() {
            progressBar1.RunWorkerAsync();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

  

      

            PedidoBL pbl = new PedidoBL();
            FacturaBL facBl = new FacturaBL();
            FacturaBE factbe = new FacturaBE();
            PedidoBE pedbe = new PedidoBE();
            DataTable dtdetallepedidos = new DataTable();
           

            if (dtpedidos.Rows.Count >=1)
            {

                Boolean procesados = false;

                DataGridViewCheckBoxCell oCell;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    dtdetallepedidos.Clear();
                    dtdetallefactura.Clear();

                    //Boolean data = Convert.ToBoolean(int.Parse(row.Cells[0].ToString()));
                    oCell = row.Cells["item"] as DataGridViewCheckBoxCell;
                    bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);

                    int codigo = int.Parse(row.Cells["Numero_Pedido"].Value.ToString());
                    int codigotipocp = int.Parse(row.Cells["codtipodocumento"].Value.ToString());
                   
                    if (bChecked)
                    {

                        procesados = true;
                        pedbe = pbl.getpedido(codigo);
                        dtdetallepedidos = pbl.obtenerDetalledPedidos_completo(codigo);

                        factbe = rellenarfactura(pedbe);
                        factbe.TipoCP = codigotipocp;
                        //construirDetallefactura(dtdetallefactura);
                        dtdetallefactura = rellenardetfactura(dtdetallepedidos);

                        if (facBl.insertFacturaDetalleXLote(factbe, dtdetallefactura))
                        {
                            pbl.updateestadopedido(codigo, "FACTURADO");

                            MessageBox.Show("Pedido Proceso :" + codigo);
                            

                        }




                    }
                
                }

                if (!procesados)
                {
                    progressBar1.Value = 100;
                    MessageBox.Show("Seleccionar un pedido para su procesamiento");
                    backgroundWorker1.CancelAsync();
                    progressBar1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Proceso Finalizado");
                    backgroundWorker1.CancelAsync();
                    progressBar1.Value = 0;
                    ACTUALIZARREGISTROS();
                }


                
            }


        }

        public void construirDetallefactura(DataTable dt)
        {
         //      new SqlParameter("@idproducto", codigoperu));
         //     new SqlParameter("@cantidad", cantidad));
                        
         //    new SqlParameter("@precio", precio));
                        
         //     new SqlParameter("@observacion", "BLABLABLA"));
                        
         //     new SqlParameter("@IdPedido", codigo));

                        
         //new SqlParameter("@ListaPrecioId", 1));

            dt.Columns.Add("idproducto", typeof(Int32));
          dt.Columns.Add("cantidad", typeof(Int32));
          dt.Columns.Add("precio", typeof(Double));
          dt.Columns.Add("observacion", typeof(String));
          dt.Columns.Add("IdPedido", typeof(Int32));
          dt.Columns.Add("ListaPrecioId", typeof(Int32));
          
        }
        public DataTable rellenardetfactura(DataTable dtpedido)
        {

            dtdetallesfacturarel.Clear();

            

            foreach (DataRow fila in dtpedido.Rows)
            {
                string valor = fila["DetallePedidoId"].ToString();
                int listaprecioid = int.Parse(fila["ListaPrecioId"].ToString());
                int pedid = int.Parse(fila["PedidoId"].ToString());
                int prodid = int.Parse(fila["ProductoId"].ToString());
                double cant = double.Parse(fila["Cantidad"].ToString());
                Double precio = double.Parse(fila["Total"].ToString());
                string Observacion = fila["Observacion"].ToString();


                dtdetallesfacturarel.Rows.Add(prodid, cant, precio, Observacion, pedid, listaprecioid);

            }


            return dtdetallesfacturarel;
        }


        public FacturaBE rellenarfactura(PedidoBE pebe)
        {
            FacturaBE fctbe = new FacturaBE();

            fctbe.FacturaId = 0;
            fctbe.ClienteId = pebe.IDCliente;
            fctbe.FechaEmision = pebe.FechaEmision;
            fctbe.FechaEntrega = pebe.FechaEntrega;
            fctbe.ModalidadCreditoId = pebe.IDModalidadCredito;
            fctbe.FechaPago = pebe.FechaPago;
            fctbe.Credito = pebe.Credito;

            fctbe.Direccion = pebe.Direccion;
            fctbe.IdVendedor = pebe.IDVendedor;
            fctbe.Observacion = pebe.Observacion;
            fctbe.ValorVenta = 0;
            fctbe.PrecioIncluyeImpuesto = pebe.PrecioIncluyeImpuesto;
            fctbe.DireccionEntrega = pebe.DireccionEntrega;
            fctbe.EstadoFacturacion = "FACTURADO POR LOTE";
            fctbe.Subtotal = 0;
            fctbe.Total = 0;
            fctbe.MontoIGV = 0;
            fctbe.Observaciones = "GENERADO DESDE PEDIDO/"+pebe.PKID;
            fctbe.CodigoReq = 1;
            fctbe.CodigoSolAtencion = 1;
            fctbe.CodigoFormato = 0;


            return fctbe;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturacionenLote_Load(object sender, EventArgs e)
        {
            txtFiltroVende.Visible = false;
            button1.Visible = false;
            txtFiltroVende.Text = "";
            strvendedor.IdVendedor = 0;
            if (strvendedor.IdVendedor == 0)
            {
                dtpedidos = pbl.getpedidos_vendedor("", dateTimePicker1.Value);
            }

            actualizardetalle(false);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (chkVen.Checked == false)
            {
                txtFiltroVende.Visible = false;
                button1.Visible = false;
                txtFiltroVende.Text = "";
                strvendedor.IdVendedor = 0;
                if (strvendedor.IdVendedor == 0)
                {
                    dtpedidos = pbl.getpedidos_vendedor("", dateTimePicker1.Value);
                }

                actualizardetalle(false);
            }
            else
            {
                txtFiltroVende.Visible = true;
                button1.Visible = true;
                txtFiltroVende.Text = "";
                strvendedor.IdVendedor = 0;
                if (strvendedor.IdVendedor == 0)
                {
                    dtpedidos = pbl.getpedidos_vendedor("", dateTimePicker1.Value);
                }

                actualizardetalle(false);

            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                // Wait 100 milliseconds.
                Thread.Sleep(100);
                // Report progress.
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = e.ProgressPercentage.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }



        private void InitializeBackgroundWorker()
        {
            _BackgroundWorker = new BackgroundWorker();
            _BackgroundWorker.WorkerReportsProgress = true;

            _BackgroundWorker.DoWork += (sender, e) => ((MethodInvoker)e.Argument).Invoke();
            _BackgroundWorker.ProgressChanged += (sender, e) =>
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Value = e.ProgressPercentage;
            };
            _BackgroundWorker.RunWorkerCompleted += (sender, e) =>
            {
                if (progressBar1.Style == ProgressBarStyle.Marquee)
                {
                    progressBar1.Visible = false;
                }
            };
        }


    }




}