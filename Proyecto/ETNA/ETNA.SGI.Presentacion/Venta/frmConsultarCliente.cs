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



    public partial class frmConsultarCliente : DevExpress.XtraEditors.XtraForm
    {

        string origenform = "";
        frmPedido frmpedido;
         frmUpPedido frmuppedido;
         frmComprobanteVenta frmComprobanteVenta;
        
        ClienteBL cbl = new ClienteBL();

        public frmConsultarCliente()
        {
            InitializeComponent();


            DataGridView1.DataSource = cbl.ObtenerClientes();
            DataGridView1.AllowUserToAddRows = false;

        }

        public frmConsultarCliente(frmPedido frm)
        {
            InitializeComponent();

            this.frmpedido = frm;
            origenform = frm.Name;

          DataGridView1.DataSource = cbl.ObtenerClientes();
          DataGridView1.AllowUserToAddRows = false;


        }

        public frmConsultarCliente(frmComprobanteVenta frm)
        {
            InitializeComponent();

            this.frmComprobanteVenta = frm;
            origenform = frm.Name;

            DataGridView1.DataSource = cbl.ObtenerClientes();
            DataGridView1.AllowUserToAddRows = false;


        }


        public frmConsultarCliente(frmUpPedido frm)
        {
            InitializeComponent();

            this.frmuppedido = frm;
            origenform = frm.Name;

            DataGridView1.DataSource = cbl.ObtenerClientes();
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
                frmpedido.txtCodCliente.Text = this.DataGridView1.SelectedCells[0].Value.ToString();
                frmpedido.txtNombreCliente.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
                frmpedido.txtDocIdentidad.Text = this.DataGridView1.SelectedCells[2].Value.ToString();
                frmpedido.txtDireccion.Text = this.DataGridView1.SelectedCells[3].Value.ToString();
                frmpedido.txtDireccionEntrega.Text = this.DataGridView1.SelectedCells[4].Value.ToString();
                frmpedido.txtmodalidad.Text = this.DataGridView1.SelectedCells[5].Value.ToString();
                frmpedido.txtlineacredito.Text = this.DataGridView1.SelectedCells[6].Value.ToString();
                
                frmpedido.emp.Id = int.Parse( this.DataGridView1.SelectedCells[7].Value.ToString());
                frmpedido.emp.codmodalidad = int.Parse( this.DataGridView1.SelectedCells[8].Value.ToString());
            }else if (origenform == "frmUpPedido" ) {
                frmuppedido.txtCodCliente.Text = this.DataGridView1.SelectedCells[0].Value.ToString();
                frmuppedido.txtNombreCliente.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
                frmuppedido.txtDocIdentidad.Text = this.DataGridView1.SelectedCells[2].Value.ToString();
                frmuppedido.txtDireccion.Text = this.DataGridView1.SelectedCells[3].Value.ToString();
                frmuppedido.txtDireccionEntrega.Text = this.DataGridView1.SelectedCells[4].Value.ToString();
                frmuppedido.txtmodalidad.Text = this.DataGridView1.SelectedCells[5].Value.ToString();
                frmuppedido.txtlineacredito.Text = this.DataGridView1.SelectedCells[6].Value.ToString();

                frmuppedido.emp.Id = int.Parse(this.DataGridView1.SelectedCells[7].Value.ToString());
                frmuppedido.emp.codmodalidad = int.Parse(this.DataGridView1.SelectedCells[8].Value.ToString());
       
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridView1.DataSource = cbl.ObtenerClientesFiltro(textBox1.Text.ToString());
        }

    }
}
