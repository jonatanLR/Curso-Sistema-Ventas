using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Modaes;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVentas : Form
    {
        private Usuario _Usuario;

        public frmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();            
        }

        private void frmVentas_Load(object sender, System.EventArgs e)
        {
            // Cargar las opciones del comboBox tipo de documento
            cbbTpDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbbTpDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });

            cbbTpDocumento.DisplayMember = "Texto";
            cbbTpDocumento.ValueMember = "Valor";
            cbbTpDocumento.SelectedIndex = 0;

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // se crea un objeto de tipo mdCliente
            using (var modal = new mdCliente())
            {
                // se obtiene el resultado del modal al hacer doble click en el cliente seleccionado
                var result = modal.ShowDialog();

                // se valida si el resultado del DialogResult sea == OK
                if (result == DialogResult.OK)
                {
                    // se guadan los valores del objeto seleccionado
                    // "_Cliente" es una propiedad de la clase mdCliente donde se guardan los valores seleccionados
                    txtIdCliente.Text = modal._Cliente.Id.ToString();
                    txtNumDocCliente.Text = modal._Cliente.Documento.ToString();
                    txtNombreCliente.Text = modal._Cliente.NombreCompleto.ToString();
                }
                else
                {
                    txtNumDocCliente.Select();
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.Id.ToString();
                    txtCodigoProducto.Text = modal._Producto.codigo.ToString();
                    txtNombreProducto.Text = modal._Producto.nombre.ToString();
                    txtPrecio.Text = modal._Producto.precioVenta.ToString("0.00");
                    txtStock.Text = modal._Producto.stock.ToString();
                    txtNumericCantidad.Select();
                }
                else
                {
                    txtCodigoProducto.Select();
                }
            }
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            // validar si el evento es igual a Enter (sea introducido el texto y se presiona la tecla enter)
            if (e.KeyData == Keys.Enter)
            {
                // busca el primer registro que coincida con el texto del control (txtCodProducto) o null si no encuentra nada
                Producto oProducto = new CN_Producto().Listar().Where(p => p.codigo == txtCodigoProducto.Text && p.estado == true).FirstOrDefault();
                // validar si el objeto que se esta buscando es diferente de null
                if (oProducto != null)
                {
                    txtCodigoProducto.BackColor = Color.Honeydew;
                    txtIdProducto.Text =oProducto.Id.ToString();
                    txtNombreProducto.Text = oProducto.nombre.ToString();
                    txtPrecio.Text = oProducto.precioVenta.ToString("0.00");
                    txtStock.Text = oProducto.stock.ToString();
                    txtNumericCantidad.Select();
                }
                else
                {
                    txtCodigoProducto.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtNombreProducto.Text = string.Empty;
                    txtPrecio.Text = string.Empty;
                    txtStock.Text = string.Empty;
                    txtNumericCantidad.Value = 1;
                }
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            // VALIDACIONES
            // validar que se haya seleccionado un producto
            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // validar que el formato del texto precio de compra sea el correcto
            // si el TryParse no convierte el texto a decimal devuelve un false y al negarlo es true
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio de Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtNumericCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor que el stock","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // validar si el producto ya existe dentro del Dgv
            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                // si el producto que se esta agregando ya existe entonces se rompe el ciclo y se pone producto_existe = true
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    // si producto existe 
                    producto_existe = true;
                    // se rompe el ciclo
                    break;
                }
            }

            // Valor de inicio de producto_existe = false
            // si el producto existe valor de producto_existe = true (lo niega entonces es false y no entra )
            // si el producto no existe valor de producto_existe = false (lo niega entonces es true y si entra)
            if (!producto_existe)
            {
                // actualizamos y obtenemos la respuesta de la resta del stock
                bool respuesta = new CN_Venta().RestarStock(
                        Convert.ToInt32(txtIdProducto.Text),
                        Convert.ToInt32(txtNumericCantidad.Value.ToString())
                    );

                // si la respuesta es true entonces agregamos el registro al DGV
                if (respuesta)
                {
                    dgvVentas.Rows.Add(new object[]
                    {
                        txtIdProducto.Text,
                        txtNombreProducto.Text,
                        precio.ToString("0.00"),
                        txtNumericCantidad.Value.ToString(),
                        (txtNumericCantidad.Value * precio).ToString("0.00")
                    });
                }

                

                CalcularTotal();
                LimpiarProducto();
                txtCodigoProducto.Select();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvVentas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodigoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtNumericCantidad.Value = 1;
        }

        private void dgvVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.eliminar.Width;
                var h = Properties.Resources.eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) /2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) /2;

                e.Graphics.DrawImage(Properties.Resources.eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                // se captura el indice de la fila que se hizo click
                int indice = e.RowIndex;

                // validar que el indice que se eligia al hacer click se mayor o igual que 0 
                // osea que no sea la fila de titulo de cada columna
                if (indice >= 0)
                {

                    //String mensaje = string.Empty;
                    bool respuesta = new CN_Venta().SumarStock(
                            Convert.ToInt32(dgvVentas.Rows[indice].Cells["IdProducto"].Value.ToString()),
                            Convert.ToInt32(dgvVentas.Rows[indice].Cells["Cantidad"].Value.ToString())
                        );

                    if (respuesta)
                    {
                        dgvVentas.Rows.RemoveAt(indice);
                        CalcularTotal();
                    }

                    
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validar que el digito ingresado sea un digito (keyChar es la tecla que se esta ingresando)
            if (char.IsDigit(e.KeyChar))
            {
                // si es un digito entonces el validador no se active
                e.Handled = false;
            }
            else
            {
                // validar que no escriba un punto al principio si la caja de texto esta vacia
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    // Permitir utilizar la tecla de borrar o escribir un punto
                    // si ya ha escrito un digito
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validar que el digito ingresado sea un digito (keyChar es la tecla que se esta ingresando)
            if (char.IsDigit(e.KeyChar))
            {
                // si es un digito entonces el validador no se active
                e.Handled = false;
            }
            else
            {
                // validar que no escriba un punto al principio si la caja de texto esta vacia
                if (txtPagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    // Permitir utilizar la tecla de borrar o escribir un punto
                    // si ya ha escrito un digito
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void CalcularCambio()
        {
            if (txtTotalPagar.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotalPagar.Text);

            if (txtPagacon.Text.Trim() == string.Empty)
            {
                txtPagacon.Text = "0";
            }

            if (decimal.TryParse(txtPagacon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtCambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtPagacon_KeyDown(object sender, KeyEventArgs e)
        {
            // validar si la tecla presionada (e.KeyData) es la tecla enter (Keys.Enter)
            if (e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            // validar que el numero de documento del cliente no sea vacio
            if (txtNumDocCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // validar que el nombre del cliente no sea vacio
            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // validar que exista productos agragados en el DGV
            if (dgvVentas.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // DataTable para guardar el detalle de venta y hacer referencia a la tabla de tipo
            // estructura de la tabla detalle_venta
            DataTable detalle_venta = new DataTable();
            // Se crean las columnas y el tipo de columna del DT
            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            // se recorren cada fila del DGV y se agregan al DataTable
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }

            // se crea una variable y se obtiene el correlativo y luego se crea otra variable para guardar
            // el correlativo con el formato deseado
            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            // se calcula el cambio
            CalcularCambio();


            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { Id = _Usuario.Id },
                tipoDocumento = ((OpcionCombo)cbbTpDocumento.SelectedItem).Texto,
                numeroDocumento = numeroDocumento,
                oCliente = new Cliente() { Id = Convert.ToInt32(txtIdCliente.Text.ToString()) },
                montoPago = Convert.ToDecimal(txtPagacon.Text),
                montoCambio = Convert.ToDecimal(txtCambio.Text),
                montoTotal = Convert.ToDecimal(txtTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtNumDocCliente.Text = "";
                txtNombreCliente.Text = "";
                dgvVentas.Rows.Clear();
                CalcularCambio();
                txtPagacon.Text = "";
                txtCambio.Text = "";
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
