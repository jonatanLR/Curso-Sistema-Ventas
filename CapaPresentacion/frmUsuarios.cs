using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // Agreaga los item al comboBox Estado mendiante la clase OpcionCombo
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbbEstado.Items.Add(new OpcionCombo() { Valor = 0 , Texto = "No Activo"});

            // se asigna los campos a mostrar al texto y valor del comboBox y dar un formato
            cbbEstado.DisplayMember = "Texto";
            cbbEstado.ValueMember = "Valor";
            cbbEstado.SelectedIndex = 0;

            // se instancia un objeto tipo list que contiene todos los roles
            List<Rol> listaRol = new CN_Rol().Listar();

            // por medio de un foreach se recorre la lista de roles y se asigna a cada comboBox
            foreach (Rol item in listaRol)
            {
                cbbRol.Items.Add(new OpcionCombo() { Valor = item.id, Texto = item.descripcion });
                
            }
            // se asigna los campos a mostrar al texto y valor del comboBox Rol y dar un formato
            cbbRol.DisplayMember = "Texto";
            cbbRol.ValueMember = "Valor";
            cbbRol.SelectedIndex = 0;

            // se captura y se capturan las columnas del DataGridView
            foreach (DataGridViewColumn dgvColumn in dgvDataUser.Columns)
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
            cbbBusqueda.SelectedIndex = 0 ;

            // Mostrar todos los usuarios
            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvDataUser.Rows.Add(new object[] { "", item.Id, item.documento, item.nombreCompleto,
                                     item.correo, item.clave,
                                     item.oRol.id, item.oRol.descripcion, 
                                     item.estado == true ? 1 : 0,
                                     item.estado == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objUsuario = new Usuario()
            {
                Id = Convert.ToInt32(txtId.Text),
                documento = txtDocumento.Text,
                nombreCompleto = txtNombreC.Text,
                correo = txtCorreo.Text,
                clave = txtClave.Text,
                oRol = new Rol() { id =  Convert.ToInt32(((OpcionCombo)cbbRol.SelectedItem).Valor) },
                estado = Convert.ToInt32(((OpcionCombo)cbbEstado.SelectedItem).Valor) == 1 ? true : false,
            };

            // se evalua si el ID del objeto usuario el igual 0 para Registrar el usuario
            if (objUsuario.Id == 0)
            {
                // registra el usuario y se guarda en una variable
                int idUserGenerado = new CN_Usuario().Registrar(objUsuario, out mensaje);

                // si el idUserGenerado es diferente de 0 entonces se procede a agregar el registro al dgv 
                if (idUserGenerado != 0)
                {
                    // Se agrega el idUsuarioGenerado
                    dgvDataUser.Rows.Add(new object[] { "", idUserGenerado, txtDocumento.Text, txtNombreC.Text,
                    txtCorreo.Text, txtClave.Text, ((OpcionCombo)cbbRol.SelectedItem).Valor.ToString(),
                                                   ((OpcionCombo)cbbRol.SelectedItem).Texto.ToString(),
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString(),
                                                   ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString()
                });

                    // si usuario es diferente a 0 que proceda a limpiar 
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                // si el ID del objeto usuario es direfente de 0 se edita el usuario
                bool resultado = new CN_Usuario().Editar(objUsuario, out mensaje);

                // se evalua el resultado para determinar su el usuario se edito correctamente
                if (resultado)
                {
                    // se crea un DataGridViewRow para obtener la fila quese edito y poder
                    // actualizar la fila de la tabla
                    DataGridViewRow dgvRow = dgvDataUser.Rows[Convert.ToInt32(txtIndice.Text)];
                    dgvRow.Cells["id"].Value = txtId.Text;
                    dgvRow.Cells["documento"].Value = txtDocumento.Text;
                    dgvRow.Cells["nombreCompleto"].Value = txtNombreC.Text;
                    dgvRow.Cells["correo"].Value = txtCorreo.Text;
                    dgvRow.Cells["clave"].Value = txtClave.Text;
                    dgvRow.Cells["rolId"].Value = ((OpcionCombo)cbbRol.SelectedItem).Valor.ToString();
                    dgvRow.Cells["rol"].Value = ((OpcionCombo)cbbRol.SelectedItem).Texto.ToString();
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
            txtDocumento.Text = string.Empty;
            txtNombreC.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtConfirmarClave.Text = string.Empty;
            cbbRol.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;

            txtDocumento.Select();
        }

        // Evento para dibujar el icono de check en la priemra columna del dgv
        // momento de creacion url="https://youtu.be/nKCL3e5gvXQ?list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&t=787"
        private void dgvDataUser_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

                e.Graphics.DrawImage(Properties.Resources.check20,new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        // Evento para mostrar los datos de usuario en los campos del formulario al hacer click en el icono check
        private void dgvDataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // se validad que se hizo click en el boton que pertenece a cada culumna
            if (dgvDataUser.Columns[e.ColumnIndex].Name == "btnSeleccionar")
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
                    DataGridViewRow dgvRow = dgvDataUser.Rows[indice]; 
                    txtIndice.Text = indice.ToString();
                    //txtId.Text = dgvDataUser.Rows[indice].Cells["id"].Value.ToString();
                    txtId.Text = dgvRow.Cells["id"].Value.ToString();
                    txtDocumento.Text = dgvRow.Cells["documento"].Value.ToString();
                    txtNombreC.Text = dgvRow.Cells["nombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvRow.Cells["correo"].Value.ToString();
                    txtClave.Text = dgvRow.Cells["clave"].Value.ToString();
                    txtConfirmarClave.Text = dgvRow.Cells["clave"].Value.ToString();

                    // Pintar la opcion del valor de la columna ROL en el comboBox Rol
                    // Obtenemos todas las opciones que tiene el comboBox y las guardamos en una variable
                    foreach (OpcionCombo oc in cbbRol.Items)
                    {
                        // validmos que el valor del objeto comboBox sea igual al valor de la columna rolI seleccionado al hacer Click
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvDataUser.Rows[indice].Cells["rolId"].Value))
                        {
                            // Obtenemos el indice seleccionado
                            int indice_combo = cbbRol.Items.IndexOf(oc);

                            // actualizar el comboBox
                            cbbRol.SelectedIndex = indice_combo; ;
                            break;
                        }
                    }

                    // Pintar la opcion del valor de la columna ROL en el comboBox Rol
                    // Obtenemos todas las opciones que tiene el comboBox y las guardamos en una variable
                    foreach (OpcionCombo oc in cbbEstado.Items)
                    {
                        // validmos que el valor del objeto comboBox sea igual al valor de la columna rolI seleccionado al hacer Click
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvDataUser.Rows[indice].Cells["estadoValor"].Value))
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
                if (MessageBox.Show("¿Desea eliminar el usuario?","Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    Usuario objUsuario = new Usuario()
                    {
                        Id = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objUsuario, out mensaje);

                    if (respuesta) { 
                        dgvDataUser.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvDataUser.Rows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dgvDataUser.Rows)
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
            foreach (DataGridViewRow dgvRow in dgvDataUser.Rows)
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

            if (dgvDataUser.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDataUser.Rows)
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
