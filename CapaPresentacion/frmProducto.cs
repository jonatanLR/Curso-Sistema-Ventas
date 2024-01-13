using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // Agreaga los item al comboBox Estado mendiante la clase OpcionCombo
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            // se asigna los campos a mostrar al texto y valor del comboBox y dar un formato
            cbbEstado.DisplayMember = "Texto";
            cbbEstado.ValueMember = "Valor";
            cbbEstado.SelectedIndex = 0;

            // se instancia un objeto tipo list que contiene todos los Categoriaes
            List<Categoria> listaCategoria = new CN_Categoria().Listar();

            // por medio de un foreach se recorre la lista de Categoriaes y se asigna a cada comboBox
            foreach (Categoria item in listaCategoria)
            {
                cbbCategoria.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.descripcion });

            }
            // se asigna los campos a mostrar al texto y valor del comboBox Categoria y dar un formato
            cbbCategoria.DisplayMember = "Texto";
            cbbCategoria.ValueMember = "Valor";
            cbbCategoria.SelectedIndex = 0;

            // se captura y se capturan las columnas del DataGridView
            foreach (DataGridViewColumn dgvColumn in dgvProducto.Columns)
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

            // Mostrar todos los Productos
            List<Producto> listaProducto = new CN_Producto().Listar();

            foreach (Producto item in listaProducto)
            {
                dgvProducto.Rows.Add(new object[] { "", item.Id, item.codigo, item.nombre,
                                     item.descripcion, item.oCategoria.Id, item.oCategoria.descripcion,
                                     item.stock, item.precioCompra, item.precioVenta,
                                     item.estado == true ? 1 : 0,
                                     item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto objProducto = new Producto()
            {
                Id = Convert.ToInt32(txtId.Text),
                codigo = txtCodigo.Text,
                nombre = txtNombreP.Text,
                descripcion = txtDescripcion.Text,
                oCategoria = new Categoria() { Id =  Convert.ToInt32(((OpcionCombo)cbbCategoria.SelectedItem).Valor) },
                estado = Convert.ToInt32(((OpcionCombo)cbbEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            // se evalua si el ID del objeto Producto el igual 0 para Registrar el Producto
            if (objProducto.Id == 0)
            {
                // registra el Producto y se guarda en una variable
                int idProductoGenerado = new CN_Producto().Registrar(objProducto, out mensaje);

                // si el idUserGenerado es diferente de 0 entonces se procede a agregar el registro al dgv 
                if (idProductoGenerado != 0)
                {
                    // Se agrega el idProductoGenerado
                    dgvProducto.Rows.Add(new object[] { "", idProductoGenerado, txtCodigo.Text, txtNombreP.Text,
                    txtDescripcion.Text, ((OpcionCombo)cbbCategoria.SelectedItem).Valor.ToString(),
                                                   ((OpcionCombo)cbbCategoria.SelectedItem).Texto.ToString(),
                                                   "0",
                                                   "0.00",
                                                   "0.00",
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString(),
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString()
                });

                    // si Producto es diferente a 0 que proceda a limpiar 
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                // si el ID del objeto Producto es direfente de 0 se edita el Producto
                bool resultado = new CN_Producto().Editar(objProducto, out mensaje);

                // se evalua el resultado para determinar su el Producto se edito correctamente
                if (resultado)
                {
                    // se crea un DataGridViewRow para obtener la fila quese edito y poder
                    // actualizar la fila de la tabla
                    DataGridViewRow dgvRow = dgvProducto.Rows[Convert.ToInt32(txtIndice.Text)];
                    dgvRow.Cells["id"].Value = txtId.Text;
                    dgvRow.Cells["codigo"].Value = txtCodigo.Text;
                    dgvRow.Cells["nombreProd"].Value = txtNombreP.Text;
                    dgvRow.Cells["descripcion"].Value = txtDescripcion.Text;
                    dgvRow.Cells["categoriaId"].Value = ((OpcionCombo)cbbCategoria.SelectedItem).Valor.ToString();
                    dgvRow.Cells["categoria"].Value =((OpcionCombo)cbbCategoria.SelectedItem).Texto.ToString();
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
            txtCodigo.Text = string.Empty;
            txtNombreP.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            cbbCategoria.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;

            txtCodigo.Select();
        }

        private void dgvProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // se validad que se hizo click en el boton que pertenece a cada culumna
            if (dgvProducto.Columns[e.ColumnIndex].Name == "btnSeleccionar")
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
                    DataGridViewRow dgvRow = dgvProducto.Rows[indice];
                    txtIndice.Text = indice.ToString();
                    //txtId.Text = dgvDataUser.Rows[indice].Cells["id"].Value.ToString();
                    txtId.Text = dgvRow.Cells["id"].Value.ToString();
                    txtCodigo.Text = dgvRow.Cells["codigo"].Value.ToString();
                    txtNombreP.Text = dgvRow.Cells["nombreProd"].Value.ToString();
                    txtDescripcion.Text = dgvRow.Cells["descripcion"].Value.ToString();

                    // Pintar la opcion del valor de la columna CATEGORIA en el comboBox Rol
                    // Obtenemos todas las opciones que tiene el comboBox y las guardamos en una variable
                    foreach (OpcionCombo oc in cbbCategoria.Items)
                    {
                        // validmos que el valor del objeto comboBox sea igual al valor de la columna rolI seleccionado al hacer Click
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProducto.Rows[indice].Cells["categoriaId"].Value))
                        {
                            // Obtenemos el indice seleccionado
                            int indice_combo = cbbCategoria.Items.IndexOf(oc);

                            // actualizar el comboBox
                            cbbCategoria.SelectedIndex = indice_combo; ;
                            break;
                        }
                    }

                    // Pintar la opcion del valor de la columna Estado en el comboBox Rol
                    // Obtenemos todas las opciones que tiene el comboBox y las guardamos en una variable
                    foreach (OpcionCombo oc in cbbEstado.Items)
                    {
                        // validmos que el valor del objeto comboBox sea igual al valor de la columna rolI seleccionado al hacer Click
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProducto.Rows[indice].Cells["estadoValor"].Value))
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
                if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Producto objProducto = new Producto()
                    {
                        Id = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        dgvProducto.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvProducto.Rows)
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
            foreach (DataGridViewRow dgvRow in dgvProducto.Rows)
            {
                dgvRow.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.ToString().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn dgvColumn in dgvProducto.Columns)
                {
                    if (dgvColumn.HeaderText != string.Empty && dgvColumn.Visible)
                    {
                        dt.Columns.Add(dgvColumn.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new Object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                        });
                    }
                }

               // Dialogo para guardar archivos
               SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFileDialog.Filter = "Excel Files | *.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error al generar el Reporte o " + ex, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
