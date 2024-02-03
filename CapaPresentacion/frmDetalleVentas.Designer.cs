namespace CapaPresentacion
{
    partial class frmDetalleVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDescargar = new FontAwesome.Sharp.IconButton();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumDocCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnDescargar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnDescargar.IconColor = System.Drawing.Color.Black;
            this.btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargar.IconSize = 28;
            this.btnDescargar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDescargar.Location = new System.Drawing.Point(918, 642);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(184, 40);
            this.btnDescargar.TabIndex = 78;
            this.btnDescargar.Text = "Descargar en PDF";
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(399, 652);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(75, 26);
            this.txtMontoTotal.TabIndex = 77;
            this.txtMontoTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(305, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Monto Total:";
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
            this.btnBuscar.Location = new System.Drawing.Point(881, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 37);
            this.btnBuscar.TabIndex = 70;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.dgvDetalleVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(309, 329);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.RowHeadersWidth = 62;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalleVenta.RowTemplate.Height = 28;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(793, 291);
            this.dgvDetalleVenta.TabIndex = 75;
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
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(996, 55);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(106, 37);
            this.btnLimpiarBuscar.TabIndex = 71;
            this.btnLimpiarBuscar.Text = "Limpiar";
            this.btnLimpiarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(634, 46);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(144, 35);
            this.txtNumeroDocumento.TabIndex = 63;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreCliente.Location = new System.Drawing.Point(351, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(258, 35);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFecha.Location = new System.Drawing.Point(27, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(199, 35);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(347, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre Cliente:";
            // 
            // txtNumDocCliente
            // 
            this.txtNumDocCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumDocCliente.Location = new System.Drawing.Point(27, 46);
            this.txtNumDocCliente.Name = "txtNumDocCliente";
            this.txtNumDocCliente.Size = new System.Drawing.Size(253, 35);
            this.txtNumDocCliente.TabIndex = 1;
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
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(492, 44);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(206, 35);
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
            this.txtTipoDocumento.Size = new System.Drawing.Size(192, 35);
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtNumeroDocumento);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNumDocCliente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.groupBox2.Location = new System.Drawing.Point(309, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 90);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
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
            this.groupBox1.Location = new System.Drawing.Point(309, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 90);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(296, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "Detalle Venta";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(660, 60);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(204, 26);
            this.txtBusqueda.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(455, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 21);
            this.label11.TabIndex = 68;
            this.label11.Text = "Numero de Documento:";
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.White;
            this.lb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb1.Location = new System.Drawing.Point(282, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(836, 686);
            this.lb1.TabIndex = 67;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(595, 652);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(75, 26);
            this.txtPago.TabIndex = 80;
            this.txtPago.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(499, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Monto Pago:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(816, 655);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(75, 26);
            this.txtCambio.TabIndex = 82;
            this.txtCambio.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(694, 655);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 81;
            this.label9.Text = "Monto Cambio:";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 8;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 250;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.MinimumWidth = 8;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 8;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 110;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = " Sub Total";
            this.SubTotal.MinimumWidth = 8;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // frmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 704);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb1);
            this.Name = "frmDetalleVentas";
            this.Text = "frmDetalleVentas";
            this.Load += new System.EventHandler(this.frmDetalleVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDescargar;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumDocCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}