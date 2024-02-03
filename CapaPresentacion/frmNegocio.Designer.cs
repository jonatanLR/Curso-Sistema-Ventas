namespace CapaPresentacion
{
    partial class frmNegocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNegocio = new System.Windows.Forms.GroupBox();
            this.btnGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreNegocio = new System.Windows.Forms.TextBox();
            this.btnSubir = new FontAwesome.Sharp.IconButton();
            this.lbLogo = new System.Windows.Forms.Label();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.gbNegocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 28);
            this.label9.TabIndex = 49;
            this.label9.Text = "Detalle Negocio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 531);
            this.label1.TabIndex = 48;
            // 
            // gbNegocio
            // 
            this.gbNegocio.BackColor = System.Drawing.Color.White;
            this.gbNegocio.Controls.Add(this.btnGuardarCambios);
            this.gbNegocio.Controls.Add(this.label4);
            this.gbNegocio.Controls.Add(this.txtRuc);
            this.gbNegocio.Controls.Add(this.label3);
            this.gbNegocio.Controls.Add(this.txtDireccion);
            this.gbNegocio.Controls.Add(this.label2);
            this.gbNegocio.Controls.Add(this.txtNombreNegocio);
            this.gbNegocio.Controls.Add(this.btnSubir);
            this.gbNegocio.Controls.Add(this.lbLogo);
            this.gbNegocio.Controls.Add(this.picbLogo);
            this.gbNegocio.Location = new System.Drawing.Point(28, 74);
            this.gbNegocio.Name = "gbNegocio";
            this.gbNegocio.Size = new System.Drawing.Size(527, 388);
            this.gbNegocio.TabIndex = 50;
            this.gbNegocio.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarCambios.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnGuardarCambios.IconSize = 25;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.Location = new System.Drawing.Point(213, 252);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(285, 38);
            this.btnGuardarCambios.TabIndex = 9;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "R.U.C:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(213, 126);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(285, 26);
            this.txtRuc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(213, 193);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(285, 26);
            this.txtDireccion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Negocio:";
            // 
            // txtNombreNegocio
            // 
            this.txtNombreNegocio.Location = new System.Drawing.Point(213, 57);
            this.txtNombreNegocio.Name = "txtNombreNegocio";
            this.txtNombreNegocio.Size = new System.Drawing.Size(285, 26);
            this.txtNombreNegocio.TabIndex = 3;
            // 
            // btnSubir
            // 
            this.btnSubir.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnSubir.IconColor = System.Drawing.Color.Black;
            this.btnSubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubir.IconSize = 20;
            this.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubir.Location = new System.Drawing.Point(17, 193);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(156, 38);
            this.btnSubir.TabIndex = 2;
            this.btnSubir.Text = "Subir";
            this.btnSubir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.Location = new System.Drawing.Point(23, 28);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(49, 20);
            this.lbLogo.TabIndex = 1;
            this.lbLogo.Text = "Logo:";
            // 
            // picbLogo
            // 
            this.picbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbLogo.Location = new System.Drawing.Point(17, 51);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(156, 133);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbLogo.TabIndex = 0;
            this.picbLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 531);
            this.Controls.Add(this.gbNegocio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frmNegocio";
            this.Text = "frmNegocio";
            this.Load += new System.EventHandler(this.frmNegocio_Load);
            this.gbNegocio.ResumeLayout(false);
            this.gbNegocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNegocio;
        private FontAwesome.Sharp.IconButton btnSubir;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreNegocio;
        private FontAwesome.Sharp.IconButton btnGuardarCambios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}