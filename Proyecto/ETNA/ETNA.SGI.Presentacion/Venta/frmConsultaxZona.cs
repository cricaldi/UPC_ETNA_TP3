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
    public partial class frmConsultaxZona : DevExpress.XtraEditors.XtraForm
    {
        ZonaBL zonabl = new ZonaBL();

        public frmConsultaxZona()
        {
            InitializeComponent();
        }

        frmCuotaVenta frmCuotaVenta;
        String origenform = "";
        private void frmConsultaxZona_Load(object sender, EventArgs e)
        {

        }


        public frmConsultaxZona(frmCuotaVenta frm)
        {
            InitializeComponent();

            this.frmCuotaVenta = frm;
            origenform = frm.Name;

            dtgZona.DataSource = zonabl.getZonas("");
          dtgZona.AllowUserToAddRows = false;
            dtgZona.SelectionMode= DataGridViewSelectionMode.FullRowSelect;



        }

        private void dtgZona_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (origenform == "frmCuotaVenta")
            {
                frmCuotaVenta.dtzona.Rows.Add(this.dtgZona.SelectedCells[0].Value.ToString(),
              this.dtgZona.SelectedCells[1].Value.ToString());
                frmCuotaVenta.actualizarZonas();
                this.Close();
            }
           
        }
    }
}