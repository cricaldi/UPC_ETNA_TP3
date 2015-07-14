namespace ETNA.SGI.Presentacion.Venta
{
    partial class frmConsultaxZona
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
            this.dtgZona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgZona)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgZona
            // 
            this.dtgZona.AllowUserToAddRows = false;
            this.dtgZona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgZona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgZona.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgZona.Location = new System.Drawing.Point(6, 5);
            this.dtgZona.Name = "dtgZona";
            this.dtgZona.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgZona.RowHeadersVisible = false;
            this.dtgZona.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgZona.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgZona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgZona.Size = new System.Drawing.Size(545, 254);
            this.dtgZona.TabIndex = 36;
            this.dtgZona.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgZona_CellClick);
            // 
            // frmConsultaxZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 262);
            this.Controls.Add(this.dtgZona);
            this.Name = "frmConsultaxZona";
            this.Text = "frmConsultaxZona";
            this.Load += new System.EventHandler(this.frmConsultaxZona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgZona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtgZona;
    }
}