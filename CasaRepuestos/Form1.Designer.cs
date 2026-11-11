namespace CasaRepuestos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(87, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(285, 47);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(35, 13);
            this.LblStock.TabIndex = 1;
            this.LblStock.Text = "Stock";
            this.LblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(380, 47);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(37, 13);
            this.LblPrecio.TabIndex = 2;
            this.LblPrecio.Text = "Precio";
            this.LblPrecio.Click += new System.EventHandler(this.lblPrecio_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(193, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(277, 63);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(43, 20);
            this.TxtStock.TabIndex = 6;
            this.TxtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(337, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(537, 63);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(88, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(456, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(631, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Location = new System.Drawing.Point(55, 109);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.Size = new System.Drawing.Size(382, 205);
            this.dgvRepuestos.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(712, 63);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Form1";
            this.Text = "Casa de repuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.Button btnEliminar;
    }
}

