using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Modaes
{
    public partial class mdCliente : Form
    {
        public Cliente _Cliente { get; set; }
        public mdCliente()
        {
            InitializeComponent();
        }

        private void mdCliente_Load(object sender, EventArgs e)
        {
            // se captura y se capturan las columnas del DataGridView
            foreach (DataGridViewColumn dgvColumn in dgvmdClientes.Columns)
            {
                
              // se agrega los valores al comboBox Busqueda 
              cbbBusqueda.Items.Add(new OpcionCombo() { Valor = dgvColumn.Name, Texto = dgvColumn.HeaderText });
                
            }
            // se asigna los campos a mostrar al texto y valor del comboBox Busqueda y dar un formato
            cbbBusqueda.DisplayMember = "Texto";
            cbbBusqueda.ValueMember = "Valor";
            cbbBusqueda.SelectedIndex = 0;

            // Mostrar todos los Proveedors
            List<Cliente> listaClientes = new CN_Cliente().Listar();

            foreach (Cliente item in listaClientes)
            {
                // validar que el cliente esta activo
                if (item.Estado)
                { 
                   dgvmdClientes.Rows.Add(new object[] { item.Id, item.Documento, item.NombreCompleto });

                }
            }
        }

        private void dgvmdClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // indice de la fila seleccionada
            int iRow = e.RowIndex;
            // obtener indice de la columna seleccionada
            int iCol = e.ColumnIndex;

            // validar que el indice de la fila sea mayor o igual que cero 0 y que el indice
            // de la columna sea mayor que cero 0 
            if (iRow >= 0 && iCol > 0)
            {
                // Propiedad de tipo cliente para asignarle los valores del Dgv que ha sido seleccionado
                _Cliente = new Cliente()
                {
                    Id = Convert.ToInt32(dgvmdClientes.Rows[iRow].Cells["id"].Value.ToString()),
                    Documento = dgvmdClientes.Rows[iRow].Cells["documento"].Value.ToString(),
                    NombreCompleto = dgvmdClientes.Rows[iRow].Cells["nombreCompleto"].Value.ToString(),
                };

                // el DialogResult que se envia al frmVentas despues de seleccionar una fila(opción)
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvmdClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvmdClientes.Rows)
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
            foreach (DataGridViewRow dgvRow in dgvmdClientes.Rows)
            {
                dgvRow.Visible = true;
            }
        }

    }
}
