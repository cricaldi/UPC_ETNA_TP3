using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ETNA.Domain.Venta;
using ETNA.BL.Venta;

namespace ETNA.SGI.Presentacion.Venta
{


    public partial class frmConsultaPedido : DevExpress.XtraEditors.XtraForm
    {

        PedidoBL pbl = new PedidoBL();

        public frmConsultaPedido()
        {
            InitializeComponent();
        }

        public EmpleadosBE emp = new EmpleadosBE();

        public frmConsultaPedido(EmpleadosBE be)
        {
            InitializeComponent();
            emp = be;
        }

        private void frmConsultaPedido_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pbl.getpedidos("");
        dataGridView1.AllowUserToAddRows = false;}

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pbl.getpedidos(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmPedido(emp).ShowDialog();
            dataGridView1.DataSource = pbl.getpedidos("");}

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea Eliminar el pedido?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                if (dataGridView1.Rows.Count >= 1)
                {

                    int codigo = int.Parse(this.dataGridView1.SelectedCells[0].Value.ToString());


                    Boolean result = pbl.deletepedido(codigo);
                    if (result == true)
                    {
                        MessageBox.Show("Pedido Eliminado exitosamente");
                        dataGridView1.DataSource = dataGridView1.DataSource = pbl.getpedidos("");
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema inesperado , comunicarse con el Administrador del sistemas"); 
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

              if (dataGridView1.Rows.Count >= 1)
                {

                    int codigo = int.Parse(this.dataGridView1.SelectedCells[0].Value.ToString());


            new frmUpPedido(codigo).ShowDialog();
               }}
    }
}