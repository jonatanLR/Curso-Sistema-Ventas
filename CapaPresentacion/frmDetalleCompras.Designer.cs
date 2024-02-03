namespace CapaPresentacion
{
    partial class frmDetalleCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumDocumentoProv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDetalleCompra = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.btnDescargar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.White;
            this.lb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb1.Location = new System.Drawing.Point(287, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(793, 677);
            this.lb1.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(619, 63);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(209, 26);
            this.txtBusqueda.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(414, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 21);
            this.label11.TabIndex = 56;
            this.label11.Text = "Numero de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(301, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Detalle Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTipoDocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.groupBox1.Location = new System.Drawing.Point(314, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 90);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Compra";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(492, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(211, 35);
            this.txtUsuario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(488, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario:";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTipoDocumento.Location = new System.Drawing.Point(260, 46);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(197, 35);
            this.txtTipoDocumento.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(256, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Documento:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFecha.Location = new System.Drawing.Point(27, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(204, 35);
            this.txtFecha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(23, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.txtNombreProveedor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNumDocumentoProv);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.groupBox2.Location = new System.Drawing.Point(314, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 90);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Proveedor";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(580, 46);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(149, 35);
            this.txtNumeroDocumento.TabIndex = 63;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreProveedor.Location = new System.Drawing.Point(260, 46);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(197, 35);
            this.txtNombreProveedor.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(256, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Razon Social:";
            // 
            // txtNumDocumentoProv
            // 
            this.txtNumDocumentoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumDocumentoProv.Location = new System.Drawing.Point(27, 46);
            this.txtNumDocumentoProv.Name = "txtNumDocumentoProv";
            this.txtNumDocumentoProv.Size = new System.Drawing.Size(204, 35);
            this.txtNumDocumentoProv.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Numero Documento:";
            // 
            // dgvDetalleCompra
            // 
            this.dgvDetalleCompra.AllowUserToAddRows = false;
            this.dgvDetalleCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dgvDetalleCompra.Location = new System.Drawing.Point(314, 329);
            this.dgvDetalleCompra.Name = "dgvDetalleCompra";
            this.dgvDetalleCompra.ReadOnly = true;
            this.dgvDetalleCompra.RowHeadersWidth = 62;
            this.dgvDetalleCompra.RowTemplate.Height = 28;
            this.dgvDetalleCompra.Size = new System.Drawing.Size(752, 272);
            this.dgvDetalleCompra.TabIndex = 63;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 150;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 8;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = " Sub Total";
            this.SubTotal.MinimumWidth = 8;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(310, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Monto Total:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(426, 635);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(129, 26);
            this.txtMontoTotal.TabIndex = 65;
            this.txtMontoTotal.Text = "0";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnDescargar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnDescargar.IconColor = System.Drawing.Color.Black;
            this.btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargar.IconSize = 28;
            this.btnDescargar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDescargar.Location = new System.Drawing.Point(877, 621);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(189, 40);
            this.btnDescargar.TabIndex = 66;
            this.btnDescargar.Text = "Descargar en PDF";
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnLimpiarBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscar.IconSize = 26;
            this.btnLimpiarBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(955, 58);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(111, 37);
            this.btnLimpiarBuscar.TabIndex = 59;
            this.btnLimpiarBuscar.Text = "Limpiar";
            this.btnLimpiarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 26;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(840, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 37);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmDetalleCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 695);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalleCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb1);
            this.Name = "frmDetalleCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDetalleCompras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumDocumentoProv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDetalleCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private FontAwesome.Sharp.IconButton btnDescargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}