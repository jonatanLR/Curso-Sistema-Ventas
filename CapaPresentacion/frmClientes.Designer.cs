namespace CapaPresentacion
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnLimpiarBuscar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.cbbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(183, 56);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(35, 26);
            this.txtIndice.TabIndex = 56;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
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
            this.btnLimpiarBuscar.Location = new System.Drawing.Point(1220, 39);
            this.btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            this.btnLimpiarBuscar.Size = new System.Drawing.Size(55, 37);
            this.btnLimpiarBuscar.TabIndex = 55;
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
            this.btnBuscar.Location = new System.Drawing.Point(1147, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 37);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbbBusqueda
            // 
            this.cbbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBusqueda.FormattingEnabled = true;
            this.cbbBusqueda.Location = new System.Drawing.Point(760, 44);
            this.cbbBusqueda.Name = "cbbBusqueda";
            this.cbbBusqueda.Size = new System.Drawing.Size(182, 28);
            this.cbbBusqueda.TabIndex = 53;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(948, 46);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(179, 26);
            this.txtBusqueda.TabIndex = 52;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(650, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Buscar Por:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(224, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 26);
            this.txtId.TabIndex = 50;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(303, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1010, 57);
            this.label10.TabIndex = 49;
            this.label10.Text = "Lista de Clientes:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(30, 529);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(211, 37);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 26;
            this.btnLimpiar.Location = new System.Drawing.Point(30, 475);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(211, 37);
            this.btnLimpiar.TabIndex = 45;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id,
            this.documento,
            this.nombreCompleto,
            this.correo,
            this.telefono,
            this.estadoValor,
            this.estado});
            this.dgvClientes.Location = new System.Drawing.Point(303, 95);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(1010, 591);
            this.dgvClientes.TabIndex = 48;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvClientes_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 23.59952F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 8;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID Cliente";
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
            // nombreCompleto
            // 
            this.nombreCompleto.FillWeight = 155.4106F;
            this.nombreCompleto.HeaderText = "Nombre Completo";
            this.nombreCompleto.MinimumWidth = 8;
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.FillWeight = 118.793F;
            this.correo.HeaderText = "Correo";
            this.correo.MinimumWidth = 8;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 8;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // estadoValor
            // 
            this.estadoValor.HeaderText = "Estado Valor";
            this.estadoValor.MinimumWidth = 8;
            this.estadoValor.Name = "estadoValor";
            this.estadoValor.ReadOnly = true;
            this.estadoValor.Visible = false;
            // 
            // estado
            // 
            this.estado.FillWeight = 83.51325F;
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 8;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 28);
            this.label9.TabIndex = 47;
            this.label9.Text = "Detalle Cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 26;
            this.btnGuardar.Location = new System.Drawing.Point(30, 423);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(211, 37);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(30, 359);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(196, 28);
            this.cbbEstado.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "Estado";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(30, 286);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 26);
            this.txtTelefono.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Telefono";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(30, 158);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(196, 26);
            this.txtNombreC.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nombre Completo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(30, 221);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(196, 26);
            this.txtCorreo.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Correo";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(30, 95);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(196, 26);
            this.txtDocumento.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "No. Documento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 720);
            this.label1.TabIndex = 29;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 720);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnLimpiarBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbbBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox cbbBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}