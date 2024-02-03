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
    public partial class frmCompras : Form
    {
        private Usuario _Usuario;
        public frmCompras(Usuario oUsuario = null)
        {
            InitializeComponent();
            _Usuario = oUsuario;
        }

        private void frmCompras_Load(object sender, System.EventArgs e)
        {
            // Cargar las opciones del comboBox tipo de documento
            cbbTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbbTipoDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });

            cbbTipoDocumento.DisplayMember = "Texto";
            cbbTipoDocumento.ValueMember = "Valor";
            cbbTipoDocumento.SelectedIndex = 0;

            // obtener la fecha actual
            txtFecha.Text = DateTime.Now.ToString("dd/mm/yyyy");

            txtIdProv.Text = "0";
            txtIdProducto.Text = "0";


        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProv.Text = modal._Proveedor.Id.ToString();
                    txtDocProveedor.Text = modal._Proveedor.Documento.ToString();
                    txtNombreProveedor.Text = modal._Proveedor.RazonSocial.ToString();
                }
                else
                {
                    txtDocProveedor.Select();
                }
            }
        }

        // url: https://youtu.be/UPxeQ4hHreE?list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&t=723
        private void btnAgregarProducto_Click(object sender, System.EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
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
            if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("Precio de Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Select();
                return;
            }

            // validar que el formato del texto precio de venta sea el correcto
            // si el TryParse no convierte el texto a decimal devuelve un false y al negarlo es true
            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("Precio de Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return;
            }

            // validar si el producto existe dentro del Dgv
            foreach (DataGridViewRow fila in dgvCompras.Rows)
            {
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
                dgvCompras.Rows.Add(new object[]
                {
                    txtIdProducto.Text,
                    txtNombreProd.Text,
                    precioCompra.ToString("0.00"),
                    precioVenta.ToString("0.00"),
                    txtnumCantidad.Value.ToString(),
                    (txtnumCantidad.Value * precioCompra).ToString("0.00")
                });

                CalcularTotal();
                LimpiarProducto();
                txtCodProducto.Select();
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
                    txtCodProducto.Text = modal._Producto.codigo.ToString();
                    txtNombreProd.Text = modal._Producto.nombre.ToString();
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtCodProducto.Select();
                }
            }
        }

        // url: https://youtu.be/UPxeQ4hHreE?list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&t=453
        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            // validar si el evento es igual a Enter (sea introducido el texto y se presiona la tecla enter)
            if (e.KeyData == Keys.Enter)
            {
                // busca el primer registro que coincida con el texto del control (txtCodProducto) o null si no encuentra nada
                Producto oProducto = new CN_Producto().Listar().Where(p => p.codigo == txtCodProducto.Text && p.estado == true).FirstOrDefault();
                // validar si el objeto que se esta buscando es diferente de null
                if (oProducto != null)
                {
                    txtCodProducto.BackColor = Color.Honeydew;
                    txtIdProducto.Text =oProducto.Id.ToString();
                    txtNombreProd.Text = oProducto.nombre.ToString();
                    txtPrecioCompra.Select();
                }
                else
                {
                    txtCodProducto.BackColor = Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtNombreProd.Text = string.Empty;
                }
            }
        }

        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = string.Empty;
            txtCodProducto.BackColor = Color.White;
            txtNombreProd.Text= string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtnumCantidad.Text = "1";
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvCompras.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvCompras.Rows)
                {
                    total = total + Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }                
            }
            txtTotalPagar.Text = total.ToString("0.00");
        }

        private void dgvCompras_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
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

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompras.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                // se captura el indice de la fila que se hizo click
                int indice = e.RowIndex;

                // validar que el indice que se eligia al hacer click se mayor o igual que 0 
                // osea que no sea la fila de titulo de cada columna
                if (indice >= 0)
                {
                    dgvCompras.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
        }

        // url: https://youtu.be/UPxeQ4hHreE?list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&t=2123
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdProv.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvCompras.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();
            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("SubTotal", typeof(decimal));

            // leer cada fila que existe en el data DGV
            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                detalle_compra.Rows.Add(new object[]
                {
                    Convert.ToInt32( row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString(),
                });
            }

            // obtener correlativo
            int idCorrelativo = new CN_Compra().ObtenerCorrelativo();
            // para tener el correlativo de la forma (00001, 00002, 000200) segun vaya aumentando
            string numeroDocumento = string.Format("{0:00000}", idCorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() {Id = _Usuario.Id },
                oProveedor = new Proveedor() { Id = Convert.ToInt32(txtIdProv.Text) },
                tipoDocumento = ((OpcionCombo)cbbTipoDocumento.SelectedItem).Texto,
                numeroDocumento = numeroDocumento,
                montoTotal = Convert.ToDecimal(txtTotalPagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generado:\n" + numeroDocumento + "\n\n Desea copiar al portapapeles?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(numeroDocumento);
                }

                // Limpiar controles
                txtIdProv.Text = "0";
                txtDocProveedor.Text = "";
                txtNombreProveedor.Text = "";
                dgvCompras.Rows.Clear();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
