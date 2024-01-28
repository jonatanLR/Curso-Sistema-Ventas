namespace CapaPresentacion.Modaes
{
    partial class mdCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvmdClientes = new System.Windows.Forms.DataGridView();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbBusqueda
            // 
            this.cbbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBusqueda.FormattingEnabled = true;
            this.cbbBusqueda.Location = new System.Drawing.Point(180, 62);
            this.cbbBusqueda.Name = "cbbBusqueda";
            this.cbbBusqueda.Size = new System.Drawing.Size(182, 28);
            this.cbbBusqueda.TabIndex = 91;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(368, 64);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(179, 26);
            this.txtBusqueda.TabIndex = 90;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 89;
            this.label11.Text = "Buscar Por:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(641, 87);
            this.label10.TabIndex = 88;
            this.label10.Text = "Lista de Clientes:";
            // 
            // dgvmdClientes
            // 
            this.dgvmdClientes.AllowUserToAddRows = false;
            this.dgvmdClientes.AllowUserToDeleteRows = false;
            this.dgvmdClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmdClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvmdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.documento,
            this.nombrecompleto});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmdClientes.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvmdClientes.Location = new System.Drawing.Point(68, 153);
            this.dgvmdClientes.MultiSelect = false;
            this.dgvmdClientes.Name = "dgvmdClientes";
            this.dgvmdClientes.ReadOnly = true;
            this.dgvmdClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvmdClientes.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvmdClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvmdClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvmdClientes.RowTemplate.Height = 28;
            this.dgvmdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmdClientes.Size = new System.Drawing.Size(641, 328);
            this.dgvmdClientes.TabIndex = 87;
            this.dgvmdClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmdClientes_CellDoubleClick);
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
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(640, 57);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(55, 37);
            this.btnLimpiarBuscar.TabIndex = 93;
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
            this.btnBuscar.Location = new System.Drawing.Point(567, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 37);
            this.btnBuscar.TabIndex = 92;
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
            // nombrecompleto
            // 
            this.nombrecompleto.FillWeight = 155.4106F;
            this.nombrecompleto.HeaderText = "Nombre Completo";
            this.nombrecompleto.MinimumWidth = 8;
            this.nombrecompleto.Name = "nombrecompleto";
            this.nombrecompleto.ReadOnly = true;
            // 
            // mdCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 521);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbbBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvmdClientes);
            this.Name = "mdCliente";
            this.Text = "mdCliente";
            this.Load += new System.EventHandler(this.mdCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvmdClientes;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
    }
}