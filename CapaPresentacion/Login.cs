using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using Capa_Negocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();

            // se crea un objeto Usuario y se busca si existe en la base de datos
            Usuario oUsuario = new CN_Usuario().Listar()
                .Where(u => u.documento == txtNoDocumento.Text && u.clave == txtContrasena.Text).FirstOrDefault();

            // Si el usuario es diferente de null se ejecuta la condicion
            if (oUsuario != null)
            {
                // se crea una instancia de form Inicio y se le pasa el objeto Usuario
                Inicio form = new Inicio(oUsuario);
                // se muestra el formulario de inicio creado
                form.Show();
                // se oculta el form actual
                this.Hide();
                // se agrega la funcionalidad de la funcion "frm_closing" (al cerrar el formulario inicio  se muestra el form login)
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario no existe, clave o numero incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Este metodo se ejecuta cuando el formulario se esta cerrando
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtNoDocumento.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            this.Show();
        }
    }
}
