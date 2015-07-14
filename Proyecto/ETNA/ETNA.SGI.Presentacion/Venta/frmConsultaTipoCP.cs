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


    public partial class frmConsultaTipoCP : DevExpress.XtraEditors.XtraForm
    {


        frmComprobanteVenta frmComprobanteVentas;
        string origen = "";
        public frmConsultaTipoCP(frmComprobanteVenta frm)
        {
            InitializeComponent();
            this.frmComprobanteVentas = frm;
            origen = frm.Name;
            DataGridView1.AllowUserToAddRows = false;

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmComprobanteVentas.txtTipoDocumento.Text = this.DataGridView1.SelectedCells[0].Value.ToString();
           // frmpedido.txtNomAlmacen.Text = this.DataGridView1.SelectedCells[1].Value.ToString();
       
        }

        private void frmConsultaTipoCP_Load(object sender, EventArgs e)
        {
            TipoCPBL t =    new TipoCPBL();
            DataGridView1.DataSource = t.gettipocp();

        }
    }
}