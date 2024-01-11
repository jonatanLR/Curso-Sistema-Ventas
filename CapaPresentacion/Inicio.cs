using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome;
using FontAwesome.Sharp;
using Capa_Negocio;

namespace CapaPresentacion
{
    /// <summary>
    /// Class <c></c>
    /// TODO Ejemplo todo
    /// </summary>
    public partial class Inicio : Form
    {
        // usuario actual para obtener el usuario en viado atraves del formulario
        private static Usuario usuarioActual;

        private static IconMenuItem iMenuActivo = null;
        private static Form formularioActivo = null;
        /// <summary>
        /// return (construct) el usuario actual de formulario que se le asigna a la variable usuarioActual
        /// retunr              the user of the current formulary and then match it to the variable "usuarioActual" 
        /// </summary>
        /// <param name="objUsuario"></param>
        public Inicio(Usuario objUsuario = null)
        {
            if (objUsuario == null)
            {
                usuarioActual = new Usuario()
                {
                    nombreCompleto = "ADMIN PREDEFINIDO",
                    Id = 1
                };
            }
            else
            {
                usuarioActual = objUsuario;
            }


            //usuarioActual = objUsuario;

            InitializeComponent();
        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {
            List<Permiso> listPermisos = new CN_Permiso().Listar(usuarioActual.Id);

            foreach (IconMenuItem menuicon in menu.Items)
            {
                bool encontrado = listPermisos.Any(m => m.nombreMenu ==  menuicon.Name.ToLower());

                if (encontrado == false)
                {
                    menuicon.Visible = false;
                }


            }


            lblUsuario.Text = usuarioActual.nombreCompleto;
        }

        private void AbrirFormualrio(IconMenuItem menu, Form formulario)
        {
            if (iMenuActivo != null)
            {
                iMenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            iMenuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            pContenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void menuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormualrio((IconMenuItem)sender, new frmUsuarios());
        }

        private void subMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuMantenedor, new frmCategoria());
        }

        private void subMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuMantenedor, new frmProducto());
        }

        private void subMenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuVentas, new frmVentas());
        }

        private void submenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuCompras, new frmCompras());
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuVentas, new frmDetalleVentas());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuCompras, new frmDetalleCompras());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormualrio((IconMenuItem)sender, new frmClientes());
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormualrio((IconMenuItem)sender, new frmProveedores());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormualrio((IconMenuItem)sender, new frmReportes());
        }
    }
}
