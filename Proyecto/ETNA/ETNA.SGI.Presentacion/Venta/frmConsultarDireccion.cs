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



    public partial class frmConsultarDireccion: DevExpress.XtraEditors.XtraForm
    {

        string origenform = "";
        frmPedido frmpedido;
        frmUpPedido frmuppedido;
        public int codigocli = 0;
        DireccionBL cbl = new DireccionBL();
        frmComprobanteVenta frmComprobanteVenta;

        public frmConsultarDireccion()
        {
            InitializeComponent();


           // DataGridView1.DataSource = cbl.getdirecciones();
            //DataGridView1.AllowUserToAddRows = false;

        }

        public frmConsultarDireccion(frmPedido frm,int cod)
        {
            InitializeComponent();

            this.frmpedido = frm;
            origenform = frm.Name;

          DataGridView1.DataSource = cbl.getdirecciones(cod,"");
            codigocli = cod;
          DataGridView1.AllowUserToAddRows = false;


        }

        public frmConsultarDireccion(frmComprobanteVenta frm, int cod)
        {
            InitializeComponent();

            this.frmComprobanteVenta = frm;
            origenform = frm.Name;

            DataGridView1.DataSource = cbl.getdirecciones(cod, "");
            codigocli = cod;
            DataGridView1.AllowUserToAddRows = false;


        }





        public frmConsultarDireccion(frmUpPedido frm, int cod)
        {
            InitializeComponent();

            this.frmuppedido = frm;
            origenform = frm.Name;

            DataGridView1.DataSource = cbl.getdirecciones(cod, "");
            codigocli = cod;
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

                frmpedido.txtDireccionEntrega.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
               
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

            DataGridView1.DataSource = cbl.getdirecciones(codigocli,textBox1.Text);
        }

    }
}
