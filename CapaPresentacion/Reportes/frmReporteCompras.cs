using Capa_Entidad;
using Capa_Negocio;
using CapaEntidad;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmReporteCompras : Form
    {
        public frmReporteCompras()
        {
            InitializeComponent();
        }

        private void frmReporteCompras_Load(object sender, EventArgs e)
        {
            // agreagar un item para que seleccione todos los proveedores por defecto
            cbbProveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });
            // se instancia un objeto tipo list que contiene todos los Proveedores
            List<Proveedor> listaProveedor = new CN_Proveedor().Listar();

            // por medio de un foreach se recorre la lista de Categoriaes y se asigna a cada comboBox
            foreach (Proveedor item in listaProveedor)
            {
                cbbProveedor.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.RazonSocial });

            }
            // se asigna los campos a mostrar al texto y valor del comboBox Categoria y dar un formato
            cbbProveedor.DisplayMember = "Texto";
            cbbProveedor.ValueMember = "Valor";
            cbbProveedor.SelectedIndex = 0;

            // Mostrar las opciones de busqueda del control cbbBusquda la se extrae de las cabeceras del DGV
            foreach (DataGridViewColumn column in dgvReporteCompra.Columns)
            {
                cbbBusqueda.Items.Add(new OpcionCombo() { Valor = column.Name, Texto = column.HeaderText });
            }

            cbbBusqueda.DisplayMember = "Texto";
            cbbBusqueda.ValueMember = "Value";
            cbbBusqueda.SelectedIndex = 0;

        }

        private void btnBuscarResultado_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(((OpcionCombo)cbbProveedor.SelectedItem).Valor.ToString());

            List<ReporteCompra> lista = new List<ReporteCompra>();

            lista = new CN_Reporte().Compra(
                        dtpFechaInicio.Value.ToString(),
                        dtpFechaFin.Value.ToString(),
                        idProveedor
                    );

            dgvReporteCompra.Rows.Clear();

            foreach (ReporteCompra rc in lista)
            {
                dgvReporteCompra.Rows.Add(new object[]
                {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
                
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvReporteCompra.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para mostrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn dgvColumn in dgvReporteCompra.Columns)
                {
                   dt.Columns.Add(dgvColumn.HeaderText, typeof(string));                    
                }

                foreach (DataGridViewRow row in dgvReporteCompra.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new Object[]
                        {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString(),
                            row.Cells[13].Value.ToString(),
                        });
                    }
                }

                // Dialogo para guardar archivos
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFileDialog.Filter = "Excel Files | *.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al generar el Reporte o " + ex, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBusqueda.SelectedItem).Valor.ToString();

            if (dgvReporteCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvReporteCompra.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.ToString().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = string.Empty;
            foreach (DataGridViewRow dgvRow in dgvReporteCompra.Rows)
            {
                dgvRow.Visible = true;
            }
        }
    }
}
