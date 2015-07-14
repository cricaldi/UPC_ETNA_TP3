using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ETNA.Domain.Venta;
using ETNA.BL.Venta;

namespace ETNA.SGI.Presentacion
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AutenticacionBL n = new AutenticacionBL();

            EmpleadosBE be = new EmpleadosBE();
            be = n.Autenticacion(textBox1.Text, textBox2.Text);


            if (be.UserProfile_UserId != 0)
            {
            DevExpress.XtraBars.Ribbon.RibbonForm frm = new Presentacion.MenuPrincipal(be);
            this.Visible = false;
            frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectas , Por favor vuelva a ingresarlas");
            }
            
          
            }

    
    
    }}
