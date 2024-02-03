using Capa_Entidad;
using Capa_Negocio;
using CapaEntidad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleVentas : Form
    {
        public frmDetalleVentas()
        {
            InitializeComponent();
        }

        private void frmDetalleVentas_Load(object sender, System.EventArgs e)
        {
            txtBusqueda.Select();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtBusqueda.Text);

            if (oVenta.Id != 0)
            {
                txtFecha.Text = oVenta.fechaRegistro;
                txtTipoDocumento.Text = oVenta.tipoDocumento;
                txtUsuario.Text = oVenta.oUsuario.nombreCompleto.ToString();

                txtNumDocCliente.Text = oVenta.oCliente.Documento;
                txtNombreCliente.Text = oVenta.oCliente.NombreCompleto;
                txtNumeroDocumento.Text = oVenta.numeroDocumento.ToString();

                // Limpiar el objeto DGV cliente
                dgvDetalleVenta.Rows.Clear();
                foreach (Detalle_Venta dv in oVenta.oDetalle_Venta)
                {
                    dgvDetalleVenta.Rows.Add(new object[] { dv.oProducto.nombre, dv.precioVenta, dv.Cantidad, dv.subTotal });
                }

                txtMontoTotal.Text = oVenta.montoTotal.ToString("0.00");
                txtPago.Text = oVenta.montoPago.ToString("0.00");
                txtCambio.Text = oVenta.montoCambio.ToString("0.00");



            }
        }

        private void btnLimpiarBuscar_Click(object sender, System.EventArgs e)
        {
            txtFecha.Text = string.Empty;
            txtTipoDocumento.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtNumDocCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;

            dgvDetalleVenta.Rows.Clear();
            txtMontoTotal.Text= "0.00";
            txtCambio.Text= "0.00";
            txtPago.Text= "0.00";
        }

        private void btnDescargar_Click(object sender, System.EventArgs e)
        {
            if (txtNumeroDocumento.Text == string.Empty)
            {
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio oDatosNegocio = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatosNegocio.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", oDatosNegocio.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", oDatosNegocio.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNumeroDocumento.Text);


            Texto_Html = Texto_Html.Replace("@doccliente", txtNumDocCliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtNombreCliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txtPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtCambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtNumeroDocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {

                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
