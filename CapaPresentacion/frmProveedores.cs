using Capa_Entidad;
using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, System.EventArgs e)
        {
            // Agreaga los item al comboBox Estado mendiante la clase OpcionCombo
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            // se asigna los campos a mostrar al texto y valor del comboBox y dar un formato
            cbbEstado.DisplayMember = "Texto";
            cbbEstado.ValueMember = "Valor";
            cbbEstado.SelectedIndex = 0;

            // se captura y se capturan las columnas del DataGridView
            foreach (DataGridViewColumn dgvColumn in dgvProveedores.Columns)
            {
                // se valida que la columna se visible que sea diferente de "btnSeleccionar"
                // osea la primera columna que contiene el boton para seleccionar la fila (row)
                if (dgvColumn.Visible == true && dgvColumn.Name != "btnSeleccionar")
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
                dgvProveedores.Rows.Add(new object[] { "", item.Id, item.Documento, item.RazonSocial,
                                     item.Correo, item.Telefono,
                                     item.Estado == true ? 1 : 0,
                                     item.Estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor objProveedor = new Proveedor()
            {
                Id = Convert.ToInt32(txtId.Text),
                Documento = txtDocumento.Text,
                RazonSocial = txtRazonSocial.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cbbEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            // se llama el metodo ValidarProveedor para recorrer y mostrar los error de cada caompo
            ValidarProveedor(objProveedor);

            // en una variable se captura la validaciones del objeto de tipo ValidationResult
            var vr = CE_Validador.ValidarObjeto(objProveedor);

            // se valida si no existen validaciones 
            if (!vr.Any())
            {
                // se evalua si el ID del objeto Proveedor el igual 0 para Registrar el Proveedor
                if (objProveedor.Id == 0)
                {
                    // registra el Proveedor y se guarda en una variable
                    int idProveedorGenerado = new CN_Proveedor().Registrar(objProveedor, out mensaje);

                    // si el idUserGenerado es diferente de 0 entonces se procede a agregar el registro al dgv 
                    if (idProveedorGenerado != 0)
                    {
                        // Se agrega el idProveedorGenerado
                        dgvProveedores.Rows.Add(new object[] { "", idProveedorGenerado, txtDocumento.Text, txtRazonSocial.Text,
                                                    txtCorreo.Text, txtTelefono.Text,
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString(),
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString()
                        });

                        // si Proveedor es diferente a 0 que proceda a limpiar 
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    // si el ID del objeto Proveedor es direfente de 0 se edita el Proveedor
                    bool resultado = new CN_Proveedor().Editar(objProveedor, out mensaje);

                    // se evalua el resultado para determinar su el Proveedor se edito correctamente
                    if (resultado)
                    {
                        // se crea un DataGridViewRow para obtener la fila quese edito y poder
                        // actualizar la fila de la tabla
                        DataGridViewRow dgvRow = dgvProveedores.Rows[Convert.ToInt32(txtIndice.Text)];
                        dgvRow.Cells["id"].Value = txtId.Text;
                        dgvRow.Cells["documento"].Value = txtDocumento.Text;
                        dgvRow.Cells["razonSocial"].Value = txtRazonSocial.Text;
                        dgvRow.Cells["correo"].Value = txtCorreo.Text;
                        dgvRow.Cells["telefono"].Value = txtTelefono.Text;
                        dgvRow.Cells["estadoValor"].Value = ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString();
                        dgvRow.Cells["estado"].Value = ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString();

                        // limpiar los campos despues de guardar cambios
                        Limpiar();
                        // Habilitar el campo txtDoc al guardar los cambios
                        //txtDocumento.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }

        // funcion para limpear o poner valor default los campos del formulario
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDocumento.Text = string.Empty;
            txtDocumento.Enabled = true;
            txtRazonSocial.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbbEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }

        // method to validate the fields of the object
        // url: https://www.youtube.com/watch?v=I-HekmLgfkk&t=479s
        private void ValidarProveedor(object obj)
        {
            var errors = CE_Validador.ValidarObjeto(obj);

            foreach (var error in errors)
            {
                MessageBox.Show(error.ErrorMessage);
                break;
            }
        }

        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) /2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) /2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // se validad que se hizo click en el boton que pertenece a cada culumna
            if (dgvProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                // se captura el indice de la fila que se hizo click
                int indice = e.RowIndex;

                // validar que el indice que se eligia al hacer click se mayor o igual que 0 
                // osea que no sea la fila de titulo de cada columna
                if (indice >= 0)
                {
                    // se asigna cada campo de la fila a su respectivo objeto text del formulario 
                    // REFACTORIZAR: it's created a varible of type DataGridViewRow to save the row index of the
                    // cell chosed named 'dgvRow' instead of 'dgvDataUser.Rows[indice]'
                    DataGridViewRow dgvRow = dgvProveedores.Rows[indice];
                    txtIndice.Text = indice.ToString();
                    //txtId.Text = dgvDataUser.Rows[indice].Cells["id"].Value.ToString();
                    txtId.Text = dgvRow.Cells["id"].Value.ToString();
                    txtDocumento.Text = dgvRow.Cells["documento"].Value.ToString();
                    txtDocumento.Enabled = false;
                    txtRazonSocial.Text = dgvRow.Cells["razonSocial"].Value.ToString();
                    txtCorreo.Text = dgvRow.Cells["correo"].Value.ToString();
                    txtTelefono.Text = dgvRow.Cells["telefono"].Value.ToString();

                    // Pintar la opcion del valor de la columna ROL en el comboBox Rol
                    // Obtenemos todas las opciones que tiene el comboBox y las guardamos en una variable
                    foreach (OpcionCombo oc in cbbEstado.Items)
                    {
                        // validmos que el valor del objeto comboBox sea igual al valor de la columna rolI seleccionado al hacer Click
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProveedores.Rows[indice].Cells["estadoValor"].Value))
                        {
                            // Obtenemos el indice seleccionado
                            int indice_combo = cbbEstado.Items.IndexOf(oc);

                            // actualizar el comboBox
                            cbbEstado.SelectedIndex = indice_combo; ;
                            break;
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Proveedor objProveedor = new Proveedor()
                    {
                        Id = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(objProveedor, out mensaje);

                    if (respuesta)
                    {
                        dgvProveedores.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvProveedores.Rows)
                {
                    if (dgvRow.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        dgvRow.Visible = true;
                    else
                        dgvRow.Visible = false;
                }
            }
        }

        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            foreach (DataGridViewRow dgvRow in dgvProveedores.Rows)
            {
                dgvRow.Visible = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProveedores.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.ToString().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }
            }
        }
    }
}
