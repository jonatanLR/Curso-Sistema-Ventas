using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Modaes
{
    public partial class mdProveedor : Form
    {
        public Proveedor _Proveedor { get; set; }
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            // se captura y se capturan las columnas del DataGridView
            foreach (DataGridViewColumn dgvColumn in dgvmdProveedores.Columns)
            {
                // se valida que la columna se visible 
                if (dgvColumn.Visible == true)
                {
                    // se agrega los valores al comboBox Busqueda 
                    cbbBusqueda.Items.Add(new OpcionCombo() { Valor = dgvColumn.Name, Texto = dgvColumn.HeaderText });
                }
            }
            // se asigna los campos a mostrar al texto y valor del comboBox Busqueda y dar un formato
            cbbBusqueda.DisplayMember = "Texto";
            cbbBusqueda.ValueMember = "Valor";
            cbbBusqueda.SelectedIndex = 0;

            // Mostrar todos los Proveedors
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedor)
            {
                dgvmdProveedores.Rows.Add(new object[] {item.Id, item.Documento, item.RazonSocial });
            }
        }

        // url: https://youtu.be/ydRuwokgimM?list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&t=2518
        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            // indice de la fila seleccionada
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol > 0)
            {
                _Proveedor = new Proveedor()
                {
                    Id = Convert.ToInt32( dgvmdProveedores.Rows[iRow].Cells["id"].Value.ToString()),
                    Documento = dgvmdProveedores.Rows[iRow].Cells["documento"].Value.ToString(),
                    RazonSocial = dgvmdProveedores.Rows[iRow].Cells["razonSocial"].Value.ToString(),
                };

                // el DialogResult que se envia al frmCompras de buscar proveedor
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvmdProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvmdProveedores.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.ToString().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }
            }
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            foreach (DataGridViewRow dgvRow in dgvmdProveedores.Rows)
            {
                dgvRow.Visible = true;
            }
        }
    }
}
