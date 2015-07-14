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
using ETNA.BL.Venta;

namespace ETNA.SGI.Presentacion.Venta
{
    public partial class frmConsultaCuotaVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmConsultaCuotaVenta()
        {
            InitializeComponent();
        }


        CuentaVentaBL bl = new CuentaVentaBL();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int valor = int.Parse(comboBox1.SelectedItem.ToString());
            DataGridView1.DataSource = bl.getcuentasventas(valor);

        }

        private void frmConsultaCuotaVenta_Load(object sender, EventArgs e)
        {



            comboBox1.Items.Add("2015");
            comboBox1.Items.Add("2014");
            comboBox1.Items.Add("2013");
            comboBox1.Items.Add("2012");
            comboBox1.Items.Add("2011");
            comboBox1.Items.Add("2010");

            
            comboBox1.SelectedIndex = 0;

            int valor = int.Parse(comboBox1.SelectedItem.ToString());
            DataGridView1.DataSource = bl.getcuentasventas(valor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmCuotaVenta().ShowDialog();

            int valor = int.Parse(comboBox1.SelectedItem.ToString());
            DataGridView1.DataSource = bl.getcuentasventas(valor);
        }
    }
}