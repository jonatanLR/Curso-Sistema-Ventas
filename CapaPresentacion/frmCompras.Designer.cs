namespace CapaPresentacion
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.txtDocProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtnumCantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRegistrarCompra = new FontAwesome.Sharp.IconButton();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1027, 640);
            this.label10.TabIndex = 22;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Registrar Compra";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbbTipoDocumento);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.groupBox1.Location = new System.Drawing.Point(47, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 97);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Compra";
            // 
            // cbbTipoDocumento
            // 
            this.cbbTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoDocumento.FormattingEnabled = true;
            this.cbbTipoDocumento.Location = new System.Drawing.Point(231, 55);
            this.cbbTipoDocumento.Name = "cbbTipoDocumento";
            this.cbbTipoDocumento.Size = new System.Drawing.Size(232, 37);
            this.cbbTipoDocumento.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFecha.Location = new System.Drawing.Point(20, 55);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(192, 35);
            this.txtFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtIdProv);
            this.groupBox2.Controls.Add(this.txtNombreProveedor);
            this.groupBox2.Controls.Add(this.btnBuscarProveedor);
            this.groupBox2.Controls.Add(this.txtDocProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.groupBox2.Location = new System.Drawing.Point(540, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 97);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Proveedor";
            // 
            // txtIdProv
            // 
            this.txtIdProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtIdProv.Location = new System.Drawing.Point(430, 15);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(39, 26);
            this.txtIdProv.TabIndex = 29;
            this.txtIdProv.Visible = false;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(261, 55);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(208, 35);
            this.txtNombreProveedor.TabIndex = 28;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 26;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(210, 55);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(44, 26);
            this.btnBuscarProveedor.TabIndex = 27;
            this.btnBuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtDocProveedor
            // 
            this.txtDocProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocProveedor.Location = new System.Drawing.Point(20, 55);
            this.txtDocProveedor.Name = "txtDocProveedor";
            this.txtDocProveedor.Size = new System.Drawing.Size(184, 35);
            this.txtDocProveedor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Razon Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "No. Documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtnumCantidad);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtPrecioVenta);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPrecioCompra);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtIdProducto);
            this.groupBox3.Controls.Add(this.txtNombreProd);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.txtCodProducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.groupBox3.Location = new System.Drawing.Point(47, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(965, 97);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // txtnumCantidad
            // 
            this.txtnumCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumCantidad.Location = new System.Drawing.Point(819, 55);
            this.txtnumCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtnumCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtnumCantidad.Name = "txtnumCantidad";
            this.txtnumCantidad.Size = new System.Drawing.Size(120, 35);
            this.txtnumCantidad.TabIndex = 35;
            this.txtnumCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(815, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Cantidad:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(668, 55);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(131, 35);
            this.txtPrecioVenta.TabIndex = 33;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(664, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(510, 55);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(134, 35);
            this.txtPrecioCompra.TabIndex = 31;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(506, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Precio Compra:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(165, 23);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(39, 26);
            this.txtIdProducto.TabIndex = 29;
            this.txtIdProducto.Visible = false;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(261, 55);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(234, 35);
            this.txtNombreProd.TabIndex = 28;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.IconSize = 26;
            this.btnBuscarProducto.Location = new System.Drawing.Point(210, 55);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 26);
            this.btnBuscarProducto.TabIndex = 27;
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(20, 55);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(184, 35);
            this.txtCodProducto.TabIndex = 2;
            this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cod. Producto:";
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btnEliminar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompras.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCompras.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCompras.Location = new System.Drawing.Point(29, 296);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCompras.RowHeadersWidth = 62;
            this.dgvCompras.RowTemplate.Height = 28;
            this.dgvCompras.Size = new System.Drawing.Size(846, 327);
            this.dgvCompras.TabIndex = 31;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellContentClick);
            this.dgvCompras.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCompras_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 8;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 80;
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
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.MinimumWidth = 8;
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
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
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 8;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 150;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(896, 412);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(131, 26);
            this.txtTotalPagar.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(900, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Total a Pagar";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnRegistrarCompra.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarCompra.IconSize = 35;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(896, 477);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(129, 45);
            this.btnRegistrarCompra.TabIndex = 35;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarProducto.IconSize = 30;
            this.btnAgregarProducto.Location = new System.Drawing.Point(896, 296);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(129, 49);
            this.btnAgregarProducto.TabIndex = 32;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 658);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTipoDocumento;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDocProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtNombreProd;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtnumCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCompras;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnRegistrarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}