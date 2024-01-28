namespace CapaPresentacion.Modaes
{
    partial class mdProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvmdProveedores = new System.Windows.Forms.DataGridView();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmdProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbBusqueda
            // 
            this.cbbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBusqueda.FormattingEnabled = true;
            this.cbbBusqueda.Location = new System.Drawing.Point(171, 61);
            this.cbbBusqueda.Name = "cbbBusqueda";
            this.cbbBusqueda.Size = new System.Drawing.Size(182, 28);
            this.cbbBusqueda.TabIndex = 84;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(359, 63);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(179, 26);
            this.txtBusqueda.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 82;
            this.label11.Text = "Buscar Por:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(641, 87);
            this.label10.TabIndex = 81;
            this.label10.Text = "Lista de Proveedores:";
            // 
            // dgvmdProveedores
            // 
            this.dgvmdProveedores.AllowUserToAddRows = false;
            this.dgvmdProveedores.AllowUserToDeleteRows = false;
            this.dgvmdProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmdProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvmdProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmdProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.documento,
            this.razonSocial});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmdProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvmdProveedores.Location = new System.Drawing.Point(59, 152);
            this.dgvmdProveedores.MultiSelect = false;
            this.dgvmdProveedores.Name = "dgvmdProveedores";
            this.dgvmdProveedores.ReadOnly = true;
            this.dgvmdProveedores.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvmdProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvmdProveedores.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvmdProveedores.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvmdProveedores.RowTemplate.Height = 28;
            this.dgvmdProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmdProveedores.Size = new System.Drawing.Size(641, 328);
            this.dgvmdProveedores.TabIndex = 80;
            this.dgvmdProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
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
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(631, 56);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(55, 37);
            this.btnLimpiarBuscar.TabIndex = 86;
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
            this.btnBuscar.Location = new System.Drawing.Point(558, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 37);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // documento
            // 
            this.documento.FillWeight = 136.9186F;
            this.documento.HeaderText = "No. Documento";
            this.documento.MinimumWidth = 8;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // razonSocial
            // 
            this.razonSocial.FillWeight = 155.4106F;
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.MinimumWidth = 8;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            // 
            // mdProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 494);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbbBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvmdProveedores);
            this.Name = "mdProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mdProveedor";
            this.Load += new System.EventHandler(this.mdProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmdProveedores)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvmdProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
    }
}