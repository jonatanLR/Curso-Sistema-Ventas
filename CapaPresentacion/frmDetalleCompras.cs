using Capa_Entidad;
using Capa_Negocio;
using CapaEntidad;
using DocumentFormat.OpenXml.Office2010.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleCompras : Form
    {
        public frmDetalleCompras()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtBusqueda.Text);

            if (oCompra.Id != 0)
            {
                txtNumeroDocumento.Text = oCompra.numeroDocumento;
                txtFecha.Text = oCompra.fechaRegistro;
                txtTipoDocumento.Text = oCompra.tipoDocumento;
                txtUsuario.Text = oCompra.oUsuario.nombreCompleto;
                txtNumDocumentoProv.Text = oCompra.oProveedor.Documento;
                txtNombreProveedor.Text = oCompra.oProveedor.RazonSocial;

                dgvDetalleCompra.Rows.Clear();

                //Detalle_Compra oDetalleCompra = cn

                foreach (Detalle_Compra dc in oCompra.oDetalle_compra)
                {
                    dgvDetalleCompra.Rows.Add(new object[] { dc.oProducto.nombre, dc.precioCompra, dc.Cantidad, dc.montoTotal });
                }

                txtMontoTotal.Text = oCompra.montoTotal.ToString("0.00");
            }
        }

        private void btnLimpiarBuscar_Click(object sender, System.EventArgs e)
        {
            txtFecha.Text = string.Empty;
            txtTipoDocumento.Text = string.Empty;
            txtUsuario.Text= string.Empty;
            txtNumDocumentoProv.Text = string.Empty;
            txtNombreProveedor.Text = string.Empty;

            dgvDetalleCompra.Rows.Clear();
            txtMontoTotal.Text = "0.00";
        }

        private void btnDescargar_Click(object sender, System.EventArgs e)
        {
            if (txtNumeroDocumento.Text == string.Empty)
            {
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio oDatosNegocio = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatosNegocio.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", oDatosNegocio.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", oDatosNegocio.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNumeroDocumento.Text);


            Texto_Html = Texto_Html.Replace("@docproveedor", txtNumDocumentoProv.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtNombreProveedor.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvDetalleCompra.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtNumeroDocumento.Text);
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
