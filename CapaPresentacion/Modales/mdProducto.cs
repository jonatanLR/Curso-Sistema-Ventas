using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Modaes
{
    public partial class mdProducto : Form
    {
        public Producto _Producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn dgvColumn in dgvmdProducto.Columns)
            {
                // se valida que la columna sea visible
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

            // Mostrar todos los Productos
            List<Producto> listaProducto = new CN_Producto().Listar();

            foreach (Producto item in listaProducto.Where(p => p.estado == true))
            {
                dgvmdProducto.Rows.Add(new object[] {item.Id, item.codigo, item.nombre,
                                     item.oCategoria.descripcion,
                                     item.stock, item.precioCompra, item.precioVenta,
                });
            }
        }

        private void dgvmdProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // indice de la fila seleccionada
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol > 0)
            {
                _Producto = new Producto()
                {
                    Id = Convert.ToInt32(dgvmdProducto.Rows[iRow].Cells["id"].Value.ToString()),
                    codigo = dgvmdProducto.Rows[iRow].Cells["codigo"].Value.ToString(),
                    nombre = dgvmdProducto.Rows[iRow].Cells["nombreProducto"].Value.ToString(),
                    stock = Convert.ToInt32(dgvmdProducto.Rows[iRow].Cells["stock"].Value.ToString()),
                    precioCompra = Convert.ToDecimal(dgvmdProducto.Rows[iRow].Cells["precioCompra"].Value.ToString()),
                    precioVenta = Convert.ToDecimal(dgvmdProducto.Rows[iRow].Cells["precioVenta"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvmdProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvmdProducto.Rows)
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
            foreach (DataGridViewRow dgvRow in dgvmdProducto.Rows)
            {
                dgvRow.Visible = true;
            }
        }
    }
}
