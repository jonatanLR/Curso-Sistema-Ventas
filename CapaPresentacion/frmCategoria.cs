using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // Agreaga los item al comboBox Estado mendiante la clase OpcionCombo
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            // se asigna los campos a mostrar al texto y valor del comboBox y dar un formato
            cbbEstado.DisplayMember = "Texto";
            cbbEstado.ValueMember = "Valor";
            cbbEstado.SelectedIndex = 0;

            //// se instancia un objeto tipo list que contiene todos los roles
            //List<Rol> listaRol = new CN_Rol().Listar();

            //// por medio de un foreach se recorre la lista de roles y se asigna a cada comboBox
            //foreach (Rol item in listaRol)
            //{
            //    cbbRol.Items.Add(new OpcionCombo() { Valor = item.id, Texto = item.descripcion });

            //}
            //// se asigna los campos a mostrar al texto y valor del comboBox Rol y dar un formato
            //cbbRol.DisplayMember = "Texto";
            //cbbRol.ValueMember = "Valor";
            //cbbRol.SelectedIndex = 0;

            // se captura y se capturan las columnas del DataGridView
            foreach (DataGridViewColumn dgvColumn in dgvCategoria.Columns)
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

            // Mostrar todos los Categorias
            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (Categoria item in listaCategoria)
            {
                dgvCategoria.Rows.Add(new object[] { "", item.Id, item.descripcion, 
                                     item.estado == true ? 1 : 0,
                                     item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categoria objCategoria = new Categoria()
            {
                Id = Convert.ToInt32(txtId.Text),
                descripcion = txtDescripcion.Text,               
                estado = Convert.ToInt32(((OpcionCombo)cbbEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            // se evalua si el ID del objeto Categoria el igual 0 para Registrar el Categoria
            if (objCategoria.Id == 0)
            {
                // registra el Categoria y se guarda en una variable
                int idCategoriaGenerado = new CN_Categoria().Registrar(objCategoria, out mensaje);

                // si el idCategoriaGenerado es diferente de 0 entonces se procede a agregar el registro al dgv 
                if (idCategoriaGenerado != 0)
                {
                    // Se agrega el idCategoriaGenerado
                    dgvCategoria.Rows.Add(new object[] { "", idCategoriaGenerado, txtDescripcion.Text, 
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString(),
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString()
                    });

                    // si Categoria es diferente a 0 que proceda a limpiar 
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                // si el ID del objeto Categoria es direfente de 0 se edita el Categoria
                bool resultado = new CN_Categoria().Editar(objCategoria, out mensaje);

                // se evalua el resultado para determinar su el Categoria se edito correctamente
                if (resultado)
                {
                    // se crea un DataGridViewRow para obtener la fila quese edito y poder
                    // actualizar la fila de la tabla
                    DataGridViewRow dgvRow = dgvCategoria.Rows[Convert.ToInt32(txtIndice.Text)];
                    dgvRow.Cells["id"].Value = txtId.Text;
                    dgvRow.Cells["descripcion"].Value = txtDescripcion.Text;                   
                    dgvRow.Cells["estadoValor"].Value = ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString();
                    dgvRow.Cells["estado"].Value = ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString();

                    Limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        // funcion para limpear o poner valor default los campos del formulario
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDescripcion.Text = string.Empty;
           
            cbbEstado.SelectedIndex = 0;

            txtDescripcion.Select();
        }


        private void dgvCategoria_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // se validad que se hizo click en el boton que pertenece a cada culumna
            if (dgvCategoria.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                // se captura el indice de la fila que se hizo click
                int indice = e.RowIndex;

                // validar que el indice que se eligia al hacer click se mayor o igual que 0 
                // osea que no sea la fila de titulo de cada columna
                if (indice >= 0)
                {
                    // se asigna cada campo de la fila a su respectivo objeto text del formulario 
                    // REFACTORIZAR: it's created a varible of type DataGridViewRow to save the row index of the
                    // cell chosed named 'dgvRow' instead of 'dgvCategoria.Rows[indice]'
                    DataGridViewRow dgvRow = dgvCategoria.Rows[indice];
                    txtIndice.Text = indice.ToString();
                    //txtId.Text = dgvCategoria.Rows[indice].Cells["id"].Value.ToString();
                    txtId.Text = dgvRow.Cells["id"].Value.ToString();
                    txtDescripcion.Text = dgvRow.Cells["descripcion"].Value.ToString();
                                       
                    // Pintar la opcion del valor de la columna ROL en el comboBox Rol
                    // Obtenemos todas las opciones que tiene el comboBox y las guardamos en una variable
                    foreach (OpcionCombo oc in cbbEstado.Items)
                    {
                        // validmos que el valor del objeto comboBox sea igual al valor de la columna rolI seleccionado al hacer Click
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvCategoria.Rows[indice].Cells["estadoValor"].Value))
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Categoria objCategoria = new Categoria()
                    {
                        Id = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Categoria().Eliminar(objCategoria, out mensaje);

                    if (respuesta)
                    {
                        dgvCategoria.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

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

            if (dgvCategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvCategoria.Rows)
                {
                    if (dgvRow.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        dgvRow.Visible = true;
                    else
                        dgvRow.Visible = false;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvCategoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCategoria.Rows)
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
            foreach (DataGridViewRow dgvRow in dgvCategoria.Rows)
            {
                dgvRow.Visible = true;
            }
        }
    }
}
