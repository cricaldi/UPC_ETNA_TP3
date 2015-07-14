using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraPrinting.Native;
using ETNA.Domain.Venta;
using ETNA.BL.Venta;

namespace ETNA.SGI.Presentacion.Venta
{



    public partial class frmConsultarVendedor : DevExpress.XtraEditors.XtraForm
    {

        string origenform = "";
        frmPedido frmpedido;
        frmCuotaVenta frmCuotaVenta;
        frmUpPedido frmUpPedido;
        frmFacturacionenLote frmFacturacionenLote;
        frmComprobanteVenta frmComprobanteVenta;


        VendedorBL cbl = new VendedorBL();

        public String strxzona;

        public frmConsultarVendedor()
        {
            InitializeComponent();


            DataGridView1.DataSource = cbl.getvendedores("");
            DataGridView1.AllowUserToAddRows = false;

        }

        public frmConsultarVendedor(frmPedido frm)
        {
            InitializeComponent();

            this.frmpedido = frm;
            origenform = frm.Name;

          DataGridView1.DataSource = cbl.getvendedores("");
          DataGridView1.AllowUserToAddRows = false;


        }


        public frmConsultarVendedor(frmFacturacionenLote frm)
        {
            InitializeComponent();

            this.frmFacturacionenLote = frm;
            origenform = frm.Name;

            DataGridView1.DataSource = cbl.getvendedores("");
            DataGridView1.AllowUserToAddRows = false;


        }

        public frmConsultarVendedor(frmComprobanteVenta frm)
        {
            InitializeComponent();

            this.frmComprobanteVenta = frm;
            origenform = frm.Name;

          DataGridView1.DataSource = cbl.getvendedores("");
          DataGridView1.AllowUserToAddRows = false;


        }

        

        public frmConsultarVendedor(frmCuotaVenta frm, string strzona)
        {
            InitializeComponent();

            this.frmCuotaVenta = frm;
            origenform = frm.Name;

            strxzona = strzona;
            DataGridView1.DataSource = cbl.getvendedores("");
            DataGridView1.AllowUserToAddRows = false;


        }


        /*Para el Update*/
        public frmConsultarVendedor(frmUpPedido frm)
        {
            InitializeComponent();

            this.frmUpPedido = frm;
            origenform = frm.Name;

            DataGridView1.DataSource = cbl.getvendedores("");
            DataGridView1.AllowUserToAddRows = false;


        }


      //  frmListPrecios frmListPrecios;

       /* public frmConsultarCliente(frmListPrecios frm)
        {
            InitializeComponent();
            origenform = "frmListPrecios";
            this.frmListPrecios = frm;

            DataGridView1.DataSource = ListaClientes.ObtenerClientes();

        }*/



    
        
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (origenform == "frmListPrecios")
            {              

                //frmListPrecios.TextBox3.Text = this.DataGridView1.SelectedCells[1].Value.ToString(); 
                
            }
            else if (origenform == "frmPedido" ) {
               frmpedido.txtCodVendedor.Text = this.DataGridView1.SelectedCells[0].Value.ToString();
               frmpedido.txtNomVendedor.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
            }
            else if (origenform == "frmUpPedido")
            {
                frmUpPedido.txtCodVendedor.Text = this.DataGridView1.SelectedCells[0].Value.ToString();
                frmUpPedido.txtNomVendedor.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
            
            }
            else if (origenform == "frmFacturacionenLote")
            {
                frmFacturacionenLote.txtFiltroVende.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
                frmFacturacionenLote.strvendedor.IdVendedor = int.Parse( this.DataGridView1.SelectedCells[0].Value.ToString());
               
            }

                

            else if (origenform == "frmCuotaVenta")
            {

                String codigo = this.DataGridView1.SelectedCells[7].Value.ToString();
                Boolean valida = false;
                //DataRow row
                DataGridView dtvendedor = new DataGridView();
                dtvendedor = frmCuotaVenta.dtgVendedor;

                foreach (DataRow row in frmCuotaVenta.dtvendedor.Rows)
                {
                   if (codigo == row[0].ToString())
                   {
                       valida = true;
                   }
                }

                if (valida == false)
                {
                    frmCuotaVenta.dtvendedor.Rows.Add(int.Parse(codigo),
                        this.DataGridView1.SelectedCells[1].Value.ToString(), strxzona);
                    
                    frmCuotaVenta.actualizaVendedor(strxzona);
                }
                else
                {
                    MessageBox.Show("Empleado ya Agregado");
                }
              

            }


            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
           // Formularios.Ventas.frmCliente frm = new Formularios.Ventas.frmCliente();
            //frm.Show();
            
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = cbl.getvendedores("");
       
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridView1.DataSource = cbl.getvendedores(textBox1.Text.ToString());
        }

    }
}
