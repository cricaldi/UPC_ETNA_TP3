using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using ETNA.SGI.Data.Ventas;
using System.Threading.Tasks;
//using ETNA.SGI.Bussiness.Ventas;
using DevExpress.XtraPrinting.Export.Pdf;
using ETNA.Domain.Venta;
using ETNA.BL.Venta;

namespace ETNA.SGI.Presentacion.Venta

{
    public partial class frmUpPedido :  DevExpress.XtraEditors.XtraForm
    {

        public EmpleadosBE emp = new EmpleadosBE();

       public PedidoBE ped = new PedidoBE();

        PedidoBL pdl = new PedidoBL();

        MonedaBL MON = new MonedaBL();
        public DataTable dtdetalle = new DataTable();

 
        ClienteBE cli = new ClienteBE();
        DireccionBE dir = new DireccionBE();
     
        AlmacenBE al = new AlmacenBE();
       ClienteBL clibl = new ClienteBL();
       AlmacenBL albl = new AlmacenBL();
        VendedorBL empbl = new VendedorBL();

        ModalidadCreditoBE modbe = new ModalidadCreditoBE();
        ModalidadCreditoBL modbl = new ModalidadCreditoBL();


        double total = 0;

        public frmUpPedido()
        {
            InitializeComponent();
        }

        public frmUpPedido(int strcodigo)
        {
            //emp = be;
            InitializeComponent();

           // txtCodVendedor.Text = be.Id.ToString();
            //txtNomVendedor.Text = be.Nombres + " " + be.Apellidos;

            ped = pdl.getpedido(strcodigo);


            cli = clibl.getcliente(ped.IDCliente);

            txtCodCliente.Text = cli.IdCliente.ToString();
            txtNombreCliente.Text = cli.Nombre.ToString();
            /*NO SE CARGA EL ALMACEN POR QUE NO SE GUARDA*/
            //al = albl.getalmacen(ped.);

            modbe = modbl.getmodalidad(cli.IDModalidadCredito);

            txtmodalidad.Text = modbe.Descripcion;

            emp = empbl.getvendedor(ped.IDVendedor);
            txtCodVendedor.Text = emp.Id.ToString();
            txtNomVendedor.Text = emp.Nombres.ToString();

            dtdetalle.Columns.Add("Codigo", typeof(String));
            dtdetalle.Columns.Add("Nombre", typeof(String));
            dtdetalle.Columns.Add("Precio", typeof(Double));
            dtdetalle.Columns.Add("Cantidad", typeof(Int32));
            dtdetalle.Columns.Add("DetallePedidoId", typeof(Int32));

            


            actualizarDetalle();
            actualizarmontos();
        }
        //BTransaccion objtra = new BTransaccion();

        private void Button7_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }


        private void dtgDetalleProd_CellEnter(object sender, System.EventArgs e)
        {

            actualizarmontos();
                

           
        }

        private void dtgDetalleProd_CellValueChanged(object sender, System.EventArgs e)
        {
            
               actualizarmontos();
            }



        private void frmUpPedido_Load(object sender, EventArgs e)
        {
            
            
            // Cargar Monedas
            cbMonedas.DisplayMember = "descripcion";
            cbMonedas.ValueMember = "MonedaID";
            cbMonedas.DataSource = MON.ObtenerMonedas();
            //

         

            /*
            dtDetPedido.Columns.AddRange(new DataColumn[8] 
                          { new DataColumn("idproducto", typeof(int)),
                            new DataColumn("codigoproducto", typeof(string)),  
                            new DataColumn("descripcion", typeof(string)),  
                            new DataColumn("cantidad",typeof(decimal)),
                            new DataColumn("unidad",typeof(string)),
                            new DataColumn("preciounitario",typeof(decimal)),
                            new DataColumn("total",typeof(decimal)),
                            new DataColumn("observacion",typeof(string))});
            */
            //dtDetPedido.Columns.RemoveAt();


            foreach (DataGridViewColumn dc in dtgDetalleProd.Columns)
            {
                if (dc.Index.Equals(3))
                {
                    dc.ReadOnly = false;
                }
                else if (dc.Index.Equals(0) || dc.Index.Equals(1) || dc.Index.Equals(2) || dc.Index.Equals(4))
                {
                    dc.ReadOnly = true;
                }
                    
                }

            

        }

        private void Button15_Click(object sender, EventArgs e)
        {
           new  frmConsultarCliente(this).ShowDialog();
        }

        public string Nombress
        {
            get { return txtNombreCliente.Text; }
            set { txtNombreCliente.Text = value; }
        }     

        private void Button6_Click(object sender, EventArgs e)
        {
            new frmConsultarVendedor(this).ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           new frmConsultarAlmacen (this).ShowDialog();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
     //        new frmConsultarDireccione(this).ShowDialog();
                       
        }

        private void Button12_Click(object sender, EventArgs e)
        {
           new frmConsultarDireccion(this,int.Parse(txtCodCliente.Text)).ShowDialog();
        }
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == false)
                txtmodalidad.Enabled = false;

            if (CheckBox3.Checked == true)
                txtmodalidad.Enabled = true ;
        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button25_Click(object sender, EventArgs e)
        {
            
              DialogResult dialogResult = MessageBox.Show("ADVERTENCIA :::::: ¿Desea Eliminar el detalle de pedido?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (dtdetalle.Rows.Count > 1)
                {

                    int codigopedidodetpedido = int.Parse(this.dtgDetalleProd.SelectedCells[4].Value.ToString());

                    if (pdl.deldetallepedido(codigopedidodetpedido))
                    {


                        for (int i = dtdetalle.Rows.Count - 1; i >= 0; i--)
                        {
                            DataRow dr = dtdetalle.Rows[i];

                            int coddetallepedidodtdetalle = int.Parse(dr["DetallePedidoId"].ToString());
                            if (coddetallepedidodtdetalle == codigopedidodetpedido)
                                dr.Delete();
                        }

                        foreach (DataGridViewRow item in this.dtgDetalleProd.SelectedRows)
                        {
                            dtgDetalleProd.Rows.RemoveAt(item.Index);
                        }

                    }
                    else if (dtdetalle.Rows.Count == 1)

                    {
                        MessageBox.Show("El pedido por lo menos debe tener un Detalle de Pedido Asignado");}





                }


            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
            
       

            actualizarmontos();
        }


        

        private void dtgDetalleProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

       
        }

        private bool skipSelectionChanged = false;

        private void SelectTabWithoutFocus(TabPage tabPage)
        {
            this.skipSelectionChanged = true;

            // "this" is the form in my case, so you get the current focused control
            // (ActiveControl), backup it, and re-set it after Tab activation

            var prevFocusedControl = this.ActiveControl;
            if (this.ActiveControl != null)
            {
                this.TabControl1.SelectedTab = tabPage;
                prevFocusedControl.Focus();
            }
            this.skipSelectionChanged = false;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            
           
            
            if  (txtCodCliente.Text == "") { MessageBox.Show("Debe seleccionar un Cliente", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); txtCodCliente.Focus(); this.Cursor = Cursors.Default; return; }
            if (dtgDetalleProd.Rows.Count == 0)
            {
                MessageBox.Show("Debe Ingresar Items", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNuevo2.Focus();
                this.Cursor = Cursors.Default;
                return;
            }


            else
                ped = new PedidoBE();
            

               int cocli = emp.Id;
            DateTime fecemision = DateTimePicker1.Value;
            DateTime fecentrega = DateTimePicker2.Value;
            

            //ped.IDModalidadCredito = emp.codmodalidad;
            //ped.Credito = true;
            //ped.Direccion = txtDireccion.Text;
            //ped.IDVendedor = int.Parse(txtCodVendedor.Text);
            //ped.Observacion = "kjhjkh";
            //ped.PrecioIncluyeImpuesto = true;
            //ped.EstadoFacturacion = "REGISTRADO";
            //ped.DireccionEntrega = txtDireccionEntrega.Text;

            PedidoBL pbl = new PedidoBL();



            DialogResult dialogResult = MessageBox.Show("ADVERTENCIA :::::: ¿Desea Actualizar el pedido?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Boolean valor = pbl.uptpedido(ped.PKID, cocli, fecemision, fecentrega);


                if (valor == true)
                {

                    MessageBox.Show("Pedido actualizado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Problema con el registro de Pedido , Comunciarse con SoporteEtna@etna.com.pe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

          




                
        }

        private void cbMonedas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodCliente.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else{
                new frmConsultarProducto(this).Show();

            }}

     
        public void actualizarmontos()
        {
           
            if (dtgDetalleProd.Rows.Count>=1 )
                {

                
            double totalsinigv = 0;
            foreach(DataGridViewRow row in dtgDetalleProd.Rows)

            {
                
                Double precio = double.Parse(row.Cells[2].Value.ToString());
                int cantidad = int.Parse(row.Cells[3].Value.ToString());
                totalsinigv = (precio * cantidad)+totalsinigv;

                


            }

            txtSubTotal.Text = totalsinigv.ToString();
                    txtafecto.Text = totalsinigv.ToString();
                   double impuesto =  totalsinigv*0.18;
                    txtimpuesto.Text = impuesto.ToString();
                        txtTotal.Text = (totalsinigv + impuesto).ToString();

                }
            else{
                txtSubTotal.Text = "0.00";
                txtTotal.Text = "0.00";
                txtafecto.Text = "0.00";
                txtimpuesto .Text = "0.00";
                txtRecargo .Text = "0.00";
                txtRecargo.Text = "0.00";
            }


        }
        public void actualizarDetalle(){

            dtdetalle.Rows.Clear();

            dtdetalle = pdl.getdetallepedido(ped.PKID);

           dtgDetalleProd.Rows.Clear();
            if (dtdetalle.Rows.Count >= 1){
                 foreach (DataRow row in dtdetalle.Rows)
                 {

                     String codigopro = row[0].ToString();
                     String descrip = row[1].ToString();

                     Double prec = double.Parse(row[2].ToString());
                        
                     Double cantidad = double.Parse(row[3].ToString());
                     int cantidadent = int.Parse(cantidad.ToString());
                     int codi = int.Parse(row[4].ToString());

                     dtgDetalleProd.Rows.Add(codigopro,
                         descrip, prec,cantidadent, codi);

                   
                 }
            }

          
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Button27_Click(object sender, EventArgs e)
        {

        }


    }
}
