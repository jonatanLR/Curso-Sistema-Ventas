namespace CapaPresentacion.Modaes
{
    partial class mdProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.cbbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvmdProducto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmdProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarBuscar
            // 
            this.btnLimpiarBuscar.BackColor = System.Drawing.Color.White;
            this.btnLimpiarBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarBuscar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscar.IconSize = 26;
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(637, 67);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(55, 37);
            this.btnLimpiarBuscar.TabIndex = 62;
            this.btnLimpiarBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarBuscar.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscar.Click += new System.EventHandler(this.btnLimpiarBuscar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 26;
            this.btnBuscar.Location = new System.Drawing.Point(574, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 37);
            this.btnBuscar.TabIndex = 61;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbbBusqueda
            // 
            this.cbbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBusqueda.FormattingEnabled = true;
            this.cbbBusqueda.Location = new System.Drawing.Point(149, 72);
            this.cbbBusqueda.Name = "cbbBusqueda";
            this.cbbBusqueda.Size = new System.Drawing.Size(182, 28);
            this.cbbBusqueda.TabIndex = 60;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(337, 74);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(220, 26);
            this.txtBusqueda.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 58;
            this.label11.Text = "Buscar Por:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 21);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.label10.Size = new System.Drawing.Size(684, 96);
            this.label10.TabIndex = 57;
            this.label10.Text = "Lista de Productos";
            // 
            // dgvmdProducto
            // 
            this.dgvmdProducto.AllowUserToAddRows = false;
            this.dgvmdProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvmdProducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmdProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvmdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmdProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombreProducto,
            this.categoria,
            this.stock,
            this.precioCompra,
            this.precioVenta});
            this.dgvmdProducto.Location = new System.Drawing.Point(22, 140);
            this.dgvmdProducto.MultiSelect = false;
            this.dgvmdProducto.Name = "dgvmdProducto";
            this.dgvmdProducto.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmdProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvmdProducto.RowHeadersWidth = 62;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvmdProducto.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvmdProducto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvmdProducto.RowTemplate.Height = 28;
            this.dgvmdProducto.Size = new System.Drawing.Size(501, 412);
            this.dgvmdProducto.TabIndex = 56;
            this.dgvmdProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmdProducto_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID ";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 73;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 74.80497F;
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 105;
            // 
            // nombreProducto
            // 
            this.nombreProducto.FillWeight = 148.2815F;
            this.nombreProducto.HeaderText = "Nombre Producto";
            this.nombreProducto.MinimumWidth = 8;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 173;
            // 
            // categoria
            // 
            this.categoria.FillWeight = 169.4757F;
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 8;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 127;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 8;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            this.stock.Width = 95;
            // 
            // precioCompra
            // 
            this.precioCompra.HeaderText = "Precio Compra";
            this.precioCompra.MinimumWidth = 8;
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.ReadOnly = true;
            this.precioCompra.Visible = false;
            this.precioCompra.Width = 153;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio Venta";
            this.precioVenta.MinimumWidth = 8;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Visible = false;
            this.precioVenta.Width = 140;
            // 
            // mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 587);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbbBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvmdProducto);
            this.Name = "mdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProducto";
            this.Load += new System.EventHandler(this.mdProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmdProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox cbbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvmdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
    }
}