namespace CapaPresentacion.Reportes
{
    partial class frmReporteCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbProveedor = new System.Windows.Forms.ComboBox();
            this.btnBuscarResultado = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvReporteCompra = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusqueda = new FontAwesome.Sharp.IconButton();
            this.cbbBusqueda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(217, 57);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(201, 26);
            this.dtpFechaInicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1231, 86);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte de Compras";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(541, 57);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaFin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(798, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Proveedor:";
            // 
            // cbbProveedor
            // 
            this.cbbProveedor.FormattingEnabled = true;
            this.cbbProveedor.Location = new System.Drawing.Point(905, 54);
            this.cbbProveedor.Name = "cbbProveedor";
            this.cbbProveedor.Size = new System.Drawing.Size(219, 28);
            this.cbbProveedor.TabIndex = 7;
            // 
            // btnBuscarResultado
            // 
            this.btnBuscarResultado.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarResultado.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarResultado.IconColor = System.Drawing.Color.Black;
            this.btnBuscarResultado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarResultado.IconSize = 28;
            this.btnBuscarResultado.Location = new System.Drawing.Point(1146, 54);
            this.btnBuscarResultado.Name = "btnBuscarResultado";
            this.btnBuscarResultado.Size = new System.Drawing.Size(113, 29);
            this.btnBuscarResultado.TabIndex = 8;
            this.btnBuscarResultado.Text = "Buscar";
            this.btnBuscarResultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarResultado.UseVisualStyleBackColor = true;
            this.btnBuscarResultado.Click += new System.EventHandler(this.btnBuscarResultado_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1231, 562);
            this.label6.TabIndex = 9;
            // 
            // dgvReporteCompra
            // 
            this.dgvReporteCompra.AllowUserToAddRows = false;
            this.dgvReporteCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.dgvReporteCompra.Location = new System.Drawing.Point(89, 193);
            this.dgvReporteCompra.Name = "dgvReporteCompra";
            this.dgvReporteCompra.ReadOnly = true;
            this.dgvReporteCompra.RowHeadersWidth = 62;
            this.dgvReporteCompra.RowTemplate.Height = 28;
            this.dgvReporteCompra.Size = new System.Drawing.Size(1185, 450);
            this.dgvReporteCompra.TabIndex = 10;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.MinimumWidth = 8;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 150;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.MinimumWidth = 8;
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 150;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.MinimumWidth = 8;
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 150;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 8;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 150;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.MinimumWidth = 8;
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            this.UsuarioRegistro.Width = 150;
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "Documento Proveedor";
            this.DocumentoProveedor.MinimumWidth = 8;
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            this.DocumentoProveedor.ReadOnly = true;
            this.DocumentoProveedor.Width = 150;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.MinimumWidth = 8;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 150;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.MinimumWidth = 8;
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 150;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.MinimumWidth = 8;
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 8;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 8;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 150;
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
            this.Cantidad.Width = 150;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 8;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 150;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBusqueda.IconColor = System.Drawing.Color.Black;
            this.btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusqueda.IconSize = 28;
            this.btnBusqueda.Location = new System.Drawing.Point(1130, 143);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(66, 29);
            this.btnBusqueda.TabIndex = 13;
            this.btnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // cbbBusqueda
            // 
            this.cbbBusqueda.FormattingEnabled = true;
            this.cbbBusqueda.Location = new System.Drawing.Point(716, 143);
            this.cbbBusqueda.Name = "cbbBusqueda";
            this.cbbBusqueda.Size = new System.Drawing.Size(187, 28);
            this.cbbBusqueda.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Buscar Por:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(909, 144);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(215, 26);
            this.txtBusqueda.TabIndex = 14;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 28;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1202, 143);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(57, 29);
            this.btnLimpiarBuscador.TabIndex = 15;
            this.btnLimpiarBuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = true;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportar.IconColor = System.Drawing.Color.LimeGreen;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExportar.IconSize = 30;
            this.btnExportar.Location = new System.Drawing.Point(89, 128);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(166, 39);
            this.btnExportar.TabIndex = 58;
            this.btnExportar.Text = "Descargar Exel";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 679);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.cbbBusqueda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvReporteCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarResultado);
            this.Controls.Add(this.cbbProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReporteCompras";
            this.Text = "Reporte de Compras";
            this.Load += new System.EventHandler(this.frmReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvReporteCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private System.Windows.Forms.ComboBox cbbBusqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private FontAwesome.Sharp.IconButton btnExportar;
    }
}