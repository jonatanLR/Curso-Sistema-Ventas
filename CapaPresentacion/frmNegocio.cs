using Capa_Entidad;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        // funcion para convertir de byte a image
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                picbLogo.Image = ByteToImage(byteImage);
            }

            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtNombreNegocio.Text = datos.Nombre;
            txtRuc.Text = datos.RUC;
            txtDireccion.Text = datos.Direccion;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImage = File.ReadAllBytes(openFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteImage, out mensaje);

                if (respuesta)
                {
                    picbLogo.Image = ByteToImage(byteImage);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            bool respuesta = true;

            Negocio objNegocio = new Negocio()
            {
                Nombre = txtNombreNegocio.Text,
                RUC = txtRuc.Text,
                Direccion = txtDireccion.Text
            };

            // se llama el metodo ValidarCliente para recorrer y mostrar los error de cada caompo
            ValidarNegocio(objNegocio);

            // en una variable se captura la validaciones del objeto de tipo ValidationResult
            var vr = CE_Validador.ValidarObjeto(objNegocio);

            if (!vr.Any())
            {
                respuesta = new CN_Negocio().GuardarDatos(objNegocio, out mensaje);
            }

            if (respuesta)
                MessageBox.Show("Los datos se guardaro con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar los cambios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ValidarNegocio(object obj)
        {
            var errors = CE_Validador.ValidarObjeto(obj);

            foreach (var error in errors)
            {
                MessageBox.Show(error.ErrorMessage);
                break;
            }
        }
    }
}
