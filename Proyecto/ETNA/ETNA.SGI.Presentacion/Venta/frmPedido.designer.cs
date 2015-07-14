using System.Windows.Forms;
using ETNA.Domain.Venta;
using ETNA.BL.Venta;

namespace ETNA.SGI.Presentacion.Venta
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDocIdentidad = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtimpuesto = new System.Windows.Forms.TextBox();
            this.txtafecto = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtNomVendedor = new System.Windows.Forms.TextBox();
            this.Button6 = new System.Windows.Forms.Button();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNuevo2 = new System.Windows.Forms.Button();
            this.Button25 = new System.Windows.Forms.Button();
            this.Button29 = new System.Windows.Forms.Button();
            this.dtgDetalleProd = new System.Windows.Forms.DataGridView();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Button12 = new System.Windows.Forms.Button();
            this.txtDireccionEntrega = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.DateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.Button10 = new System.Windows.Forms.Button();
            this.txtmodalidad = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.txtlineacredito = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.txtCodAlmacen = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNomAlmacen = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button15 = new System.Windows.Forms.Button();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.cbMonedas = new System.Windows.Forms.ComboBox();
            this.codigoproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciolistaventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleProd)).BeginInit();
            this.TabPage1.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDocIdentidad
            // 
            this.txtDocIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocIdentidad.Location = new System.Drawing.Point(623, 15);
            this.txtDocIdentidad.Name = "txtDocIdentidad";
            this.txtDocIdentidad.Size = new System.Drawing.Size(151, 21);
            this.txtDocIdentidad.TabIndex = 100;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label15.Location = new System.Drawing.Point(498, 15);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(95, 16);
            this.Label15.TabIndex = 99;
            this.Label15.Text = "Doc. Identidad";
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Checked = true;
            this.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckBox2.Location = new System.Drawing.Point(15, 455);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(151, 17);
            this.CheckBox2.TabIndex = 98;
            this.CheckBox2.Text = "Precios incluyen impuesto ";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(691, 406);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(83, 21);
            this.txtTotal.TabIndex = 97;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtimpuesto.Location = new System.Drawing.Point(691, 380);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(83, 21);
            this.txtimpuesto.TabIndex = 96;
            this.txtimpuesto.Text = "0.00";
            this.txtimpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtafecto
            // 
            this.txtafecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtafecto.Location = new System.Drawing.Point(691, 356);
            this.txtafecto.Name = "txtafecto";
            this.txtafecto.Size = new System.Drawing.Size(83, 21);
            this.txtafecto.TabIndex = 95;
            this.txtafecto.Text = "0.00";
            this.txtafecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtafecto.TextChanged += new System.EventHandler(this.TextBox13_TextChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label12.Location = new System.Drawing.Point(623, 410);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(39, 16);
            this.Label12.TabIndex = 94;
            this.Label12.Text = "Total";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label13.Location = new System.Drawing.Point(623, 384);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(63, 16);
            this.Label13.TabIndex = 93;
            this.Label13.Text = "Impuesto";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label14.Location = new System.Drawing.Point(623, 356);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(46, 16);
            this.Label14.TabIndex = 92;
            this.Label14.Text = "Afecto";
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Silver;
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button7.Location = new System.Drawing.Point(673, 455);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(101, 23);
            this.Button7.TabIndex = 62;
            this.Button7.Text = "&Cancelar";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.Silver;
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button8.Location = new System.Drawing.Point(544, 455);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(109, 23);
            this.Button8.TabIndex = 60;
            this.Button8.Text = "&Aceptar";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // txtRecargo
            // 
            this.txtRecargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecargo.Location = new System.Drawing.Point(528, 406);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.Size = new System.Drawing.Size(84, 21);
            this.txtRecargo.TabIndex = 91;
            this.txtRecargo.Text = "0.00";
            this.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuentos.Location = new System.Drawing.Point(528, 380);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.Size = new System.Drawing.Size(84, 21);
            this.txtDescuentos.TabIndex = 90;
            this.txtDescuentos.Text = "0.00";
            this.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Location = new System.Drawing.Point(528, 356);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(84, 21);
            this.txtSubTotal.TabIndex = 89;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label11.Location = new System.Drawing.Point(449, 410);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(68, 16);
            this.Label11.TabIndex = 88;
            this.Label11.Text = "Recargos";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label10.Location = new System.Drawing.Point(449, 384);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(80, 16);
            this.Label10.TabIndex = 87;
            this.Label10.Text = "Descuentos";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label9.Location = new System.Drawing.Point(449, 356);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(63, 16);
            this.Label9.TabIndex = 86;
            this.Label9.Text = "SubTotal";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label8.Location = new System.Drawing.Point(9, 386);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(85, 16);
            this.Label8.TabIndex = 84;
            this.Label8.Text = "Observación";
            // 
            // txtNomVendedor
            // 
            this.txtNomVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomVendedor.Location = new System.Drawing.Point(185, 354);
            this.txtNomVendedor.Name = "txtNomVendedor";
            this.txtNomVendedor.ReadOnly = true;
            this.txtNomVendedor.Size = new System.Drawing.Size(236, 21);
            this.txtNomVendedor.TabIndex = 82;
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Gainsboro;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Image = global::ETNA.SGI.Presentacion.Properties.Resources.icono_lupa;
            this.Button6.Location = new System.Drawing.Point(150, 353);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(29, 20);
            this.Button6.TabIndex = 81;
            this.Button6.Text = "...";
            this.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodVendedor.Location = new System.Drawing.Point(101, 353);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.ReadOnly = true;
            this.txtCodVendedor.Size = new System.Drawing.Size(72, 21);
            this.txtCodVendedor.TabIndex = 79;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label5.Location = new System.Drawing.Point(9, 354);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 16);
            this.Label5.TabIndex = 80;
            this.Label5.Text = "Vendedor";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(9, 116);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(769, 220);
            this.TabControl1.TabIndex = 78;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TabPage2.Controls.Add(this.label7);
            this.TabPage2.Controls.Add(this.btnNuevo2);
            this.TabPage2.Controls.Add(this.Button25);
            this.TabPage2.Controls.Add(this.Button29);
            this.TabPage2.Controls.Add(this.dtgDetalleProd);
            this.TabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(761, 194);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Detalle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(22, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(472, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "DAR DOBLE CLICK A LA COLUMNA CANTIDAD PARA EDITARLA";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnNuevo2
            // 
            this.btnNuevo2.BackColor = System.Drawing.Color.Silver;
            this.btnNuevo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNuevo2.Location = new System.Drawing.Point(547, 165);
            this.btnNuevo2.Name = "btnNuevo2";
            this.btnNuevo2.Size = new System.Drawing.Size(101, 23);
            this.btnNuevo2.TabIndex = 11;
            this.btnNuevo2.Text = "&Nuevo";
            this.btnNuevo2.UseVisualStyleBackColor = false;
            this.btnNuevo2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button25
            // 
            this.Button25.BackColor = System.Drawing.Color.Silver;
            this.Button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button25.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button25.Location = new System.Drawing.Point(654, 165);
            this.Button25.Name = "Button25";
            this.Button25.Size = new System.Drawing.Size(101, 23);
            this.Button25.TabIndex = 10;
            this.Button25.Text = "&Eliminar";
            this.Button25.UseVisualStyleBackColor = false;
            this.Button25.Click += new System.EventHandler(this.Button25_Click);
            // 
            // Button29
            // 
            this.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button29.Location = new System.Drawing.Point(772, 13);
            this.Button29.Name = "Button29";
            this.Button29.Size = new System.Drawing.Size(30, 20);
            this.Button29.TabIndex = 6;
            this.Button29.Text = "...";
            this.Button29.UseVisualStyleBackColor = true;
            // 
            // dtgDetalleProd
            // 
            this.dtgDetalleProd.AllowUserToAddRows = false;
            this.dtgDetalleProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDetalleProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgDetalleProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproducto,
            this.Nombre,
            this.preciolistaventa,
            this.cantidad});
            this.dtgDetalleProd.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgDetalleProd.Location = new System.Drawing.Point(0, 0);
            this.dtgDetalleProd.Name = "dtgDetalleProd";
            this.dtgDetalleProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgDetalleProd.RowHeadersVisible = false;
            this.dtgDetalleProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgDetalleProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgDetalleProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalleProd.Size = new System.Drawing.Size(761, 156);
            this.dtgDetalleProd.TabIndex = 3;
            this.dtgDetalleProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleProd_CellContentClick);
            this.dtgDetalleProd.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleProd_CellEnter);
            this.dtgDetalleProd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetalleProd_CellValueChanged);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TabPage1.Controls.Add(this.Button12);
            this.TabPage1.Controls.Add(this.txtDireccionEntrega);
            this.TabPage1.Controls.Add(this.Label16);
            this.TabPage1.Controls.Add(this.txtDireccion);
            this.TabPage1.Controls.Add(this.Label17);
            this.TabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(761, 194);
            this.TabPage1.TabIndex = 3;
            this.TabPage1.Text = "Logística";
            // 
            // Button12
            // 
            this.Button12.BackColor = System.Drawing.Color.Gainsboro;
            this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button12.Location = new System.Drawing.Point(411, 71);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(31, 20);
            this.Button12.TabIndex = 30;
            this.Button12.Text = "...";
            this.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button12.UseVisualStyleBackColor = false;
            this.Button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // txtDireccionEntrega
            // 
            this.txtDireccionEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionEntrega.Location = new System.Drawing.Point(162, 71);
            this.txtDireccionEntrega.Name = "txtDireccionEntrega";
            this.txtDireccionEntrega.Size = new System.Drawing.Size(274, 21);
            this.txtDireccionEntrega.TabIndex = 29;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(15, 71);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(134, 16);
            this.Label16.TabIndex = 26;
            this.Label16.Text = "Dirección de Entrega";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(162, 30);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(274, 21);
            this.txtDireccion.TabIndex = 23;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(15, 30);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(65, 16);
            this.Label17.TabIndex = 24;
            this.Label17.Text = "Dirección";
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TabPage5.Controls.Add(this.DateTimePicker3);
            this.TabPage5.Controls.Add(this.Label22);
            this.TabPage5.Controls.Add(this.Button10);
            this.TabPage5.Controls.Add(this.txtmodalidad);
            this.TabPage5.Controls.Add(this.Label21);
            this.TabPage5.Controls.Add(this.CheckBox3);
            this.TabPage5.Controls.Add(this.txtsaldo);
            this.TabPage5.Controls.Add(this.txtlineacredito);
            this.TabPage5.Controls.Add(this.Label19);
            this.TabPage5.Controls.Add(this.Label20);
            this.TabPage5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(761, 194);
            this.TabPage5.TabIndex = 2;
            this.TabPage5.Text = "Condiciones Comerciales";
            // 
            // DateTimePicker3
            // 
            this.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker3.Location = new System.Drawing.Point(166, 127);
            this.DateTimePicker3.Name = "DateTimePicker3";
            this.DateTimePicker3.Size = new System.Drawing.Size(156, 21);
            this.DateTimePicker3.TabIndex = 59;
            this.DateTimePicker3.Value = new System.DateTime(2015, 4, 2, 0, 0, 0, 0);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.Location = new System.Drawing.Point(24, 127);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(101, 16);
            this.Label22.TabIndex = 58;
            this.Label22.Text = "Fecha de Pago";
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.Gainsboro;
            this.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button10.Location = new System.Drawing.Point(384, 92);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(34, 20);
            this.Button10.TabIndex = 57;
            this.Button10.Text = "...";
            this.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button10.UseVisualStyleBackColor = false;
            // 
            // txtmodalidad
            // 
            this.txtmodalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmodalidad.Location = new System.Drawing.Point(166, 92);
            this.txtmodalidad.Name = "txtmodalidad";
            this.txtmodalidad.Size = new System.Drawing.Size(252, 21);
            this.txtmodalidad.TabIndex = 56;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.Location = new System.Drawing.Point(24, 95);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(136, 16);
            this.Label21.TabIndex = 55;
            this.Label21.Text = "Modalidad de crédito";
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Checked = true;
            this.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox3.Location = new System.Drawing.Point(107, 73);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(61, 17);
            this.CheckBox3.TabIndex = 54;
            this.CheckBox3.Text = "Crédito";
            this.CheckBox3.UseVisualStyleBackColor = true;
            this.CheckBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // txtsaldo
            // 
            this.txtsaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsaldo.Location = new System.Drawing.Point(166, 40);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(121, 21);
            this.txtsaldo.TabIndex = 53;
            this.txtsaldo.Text = "0.00";
            this.txtsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtlineacredito
            // 
            this.txtlineacredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlineacredito.Location = new System.Drawing.Point(166, 16);
            this.txtlineacredito.Name = "txtlineacredito";
            this.txtlineacredito.Size = new System.Drawing.Size(121, 21);
            this.txtlineacredito.TabIndex = 52;
            this.txtlineacredito.Text = "0.00";
            this.txtlineacredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(18, 44);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(44, 16);
            this.Label19.TabIndex = 51;
            this.Label19.Text = "Saldo";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.Location = new System.Drawing.Point(18, 16);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(106, 16);
            this.Label20.TabIndex = 50;
            this.Label20.Text = "Línea de Crédito";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker2.Location = new System.Drawing.Point(622, 80);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(156, 21);
            this.DateTimePicker2.TabIndex = 77;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(622, 50);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(156, 21);
            this.DateTimePicker1.TabIndex = 76;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label4.Location = new System.Drawing.Point(498, 84);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(115, 16);
            this.Label4.TabIndex = 75;
            this.Label4.Text = "Fecha de Entrega";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label3.Location = new System.Drawing.Point(498, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(116, 16);
            this.Label3.TabIndex = 74;
            this.Label3.Text = "Fecha de Emisión";
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Gainsboro;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Image = global::ETNA.SGI.Presentacion.Properties.Resources.icono_lupa;
            this.Button4.Location = new System.Drawing.Point(133, 87);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(29, 20);
            this.Button4.TabIndex = 73;
            this.Button4.Text = "...";
            this.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtCodAlmacen
            // 
            this.txtCodAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodAlmacen.Location = new System.Drawing.Point(84, 87);
            this.txtCodAlmacen.Name = "txtCodAlmacen";
            this.txtCodAlmacen.ReadOnly = true;
            this.txtCodAlmacen.Size = new System.Drawing.Size(72, 21);
            this.txtCodAlmacen.TabIndex = 72;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreCliente.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txtNombreCliente.Location = new System.Drawing.Point(174, 14);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(252, 21);
            this.txtNombreCliente.TabIndex = 68;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtNomAlmacen
            // 
            this.txtNomAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomAlmacen.Location = new System.Drawing.Point(174, 88);
            this.txtNomAlmacen.Name = "txtNomAlmacen";
            this.txtNomAlmacen.ReadOnly = true;
            this.txtNomAlmacen.Size = new System.Drawing.Size(252, 21);
            this.txtNomAlmacen.TabIndex = 65;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label2.Location = new System.Drawing.Point(9, 91);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 16);
            this.Label2.TabIndex = 66;
            this.Label2.Text = "Almacén";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label1.Location = new System.Drawing.Point(9, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 16);
            this.Label1.TabIndex = 64;
            this.Label1.Text = "Moneda";
            // 
            // Button15
            // 
            this.Button15.BackColor = System.Drawing.Color.Gainsboro;
            this.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button15.Image = global::ETNA.SGI.Presentacion.Properties.Resources.icono_lupa;
            this.Button15.Location = new System.Drawing.Point(133, 13);
            this.Button15.Name = "Button15";
            this.Button15.Size = new System.Drawing.Size(29, 20);
            this.Button15.TabIndex = 63;
            this.Button15.Text = "...";
            this.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button15.UseVisualStyleBackColor = false;
            this.Button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodCliente.Location = new System.Drawing.Point(84, 13);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.ReadOnly = true;
            this.txtCodCliente.Size = new System.Drawing.Size(72, 21);
            this.txtCodCliente.TabIndex = 59;
            this.txtCodCliente.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label6.Location = new System.Drawing.Point(9, 14);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(49, 16);
            this.Label6.TabIndex = 61;
            this.Label6.Text = "Cliente";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(100, 383);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(321, 55);
            this.textBox20.TabIndex = 106;
            // 
            // cbMonedas
            // 
            this.cbMonedas.FormattingEnabled = true;
            this.cbMonedas.Location = new System.Drawing.Point(84, 49);
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Size = new System.Drawing.Size(78, 21);
            this.cbMonedas.TabIndex = 107;
            this.cbMonedas.SelectedIndexChanged += new System.EventHandler(this.cbMonedas_SelectedIndexChanged);
            // 
            // codigoproducto
            // 
            this.codigoproducto.FillWeight = 64.65898F;
            this.codigoproducto.HeaderText = "Codigo";
            this.codigoproducto.Name = "codigoproducto";
            this.codigoproducto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 235.476F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // preciolistaventa
            // 
            this.preciolistaventa.FillWeight = 47.07308F;
            this.preciolistaventa.HeaderText = "Precio";
            this.preciolistaventa.Name = "preciolistaventa";
            this.preciolistaventa.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.FillWeight = 52.79187F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 496);
            this.Controls.Add(this.cbMonedas);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.txtDocIdentidad);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.CheckBox2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtimpuesto);
            this.Controls.Add(this.txtafecto);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.txtRecargo);
            this.Controls.Add(this.txtDescuentos);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtNomVendedor);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.txtCodVendedor);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.txtCodAlmacen);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtNomAlmacen);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button15);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.Label6);
            this.Name = "frmPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleProd)).EndInit();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBox4_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void Button26_Click(object sender, System.EventArgs e)
        {
           
            
        }

        #endregion

        internal System.Windows.Forms.TextBox txtDocIdentidad;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtimpuesto;
        internal System.Windows.Forms.TextBox txtafecto;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.TextBox txtRecargo;
        internal System.Windows.Forms.TextBox txtDescuentos;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtNomVendedor;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.TextBox txtCodVendedor;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button Button25;
        internal System.Windows.Forms.Button Button29;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Button Button12;
        internal System.Windows.Forms.TextBox txtDireccionEntrega;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.DateTimePicker DateTimePicker3;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Button Button10;
        internal System.Windows.Forms.TextBox txtmodalidad;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.CheckBox CheckBox3;
        internal System.Windows.Forms.TextBox txtsaldo;
        internal System.Windows.Forms.TextBox txtlineacredito;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.TextBox txtCodAlmacen;
        internal System.Windows.Forms.TextBox txtNombreCliente;
        internal System.Windows.Forms.TextBox txtNomAlmacen;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button15;
        internal System.Windows.Forms.TextBox txtCodCliente;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.ComboBox cbMonedas;
        internal DataGridView dtgDetalleProd;
        internal Button btnNuevo2;
        private Label label7;
        private DataGridViewTextBoxColumn codigoproducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn preciolistaventa;
        private DataGridViewTextBoxColumn cantidad;
    }
}