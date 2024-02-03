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
using CapaPresentacion.Reportes;

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

        // almacenar o indicar el menu activo que se esta usando en el menu
        private static IconMenuItem iMenuActivo = null;

        // almacena o indicar el formulario activo que se esta usando en el menu
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

        // metodo para abrir formulario recibe 2 parametros
        // 1 => IconMenuItem (es un tipo de control que aparecen como opcion en
        //      el StripMenu para abrir un Fomr)
        // 2 => Form que hacer referencia al formulario que se esta abriendo
        private void AbrirFormualrio(IconMenuItem menu, Form formulario)
        {
            // si hay otro menu que ha sido seleccionado anteriormente pone backColor en blanco
            // para que se ponga deseccionado
            if (iMenuActivo != null)
            {
                iMenuActivo.BackColor = Color.White;
            }

            // se pone color gris al IconMenu para que parezca se leccionado o active
            menu.BackColor = Color.Silver;
            // se asigna el menu actual a 'iMenuActivo' el que se desea que se muestre
            iMenuActivo = menu;

            // Si habia otro formalario abierto se cierra para poder mostrar el nuevo formulario seleccionado
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            // se asigna el formulario seleccionado a 'formalarioActivo' o el que se desea que se muestre
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            //formulario.MdiParent = this;

            // Se agrega el formulario al contenedor
            // 'pContenedor' => es el contenedor ubicado abajo de MenuStrip donde se muestra
            //                  el formulario seleccionado 
            pContenedor.Controls.Add(formulario);
            // se muestra el formulario
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
            AbrirFormualrio(menuVentas, new frmVentas(usuarioActual));
        }

        private void submenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuCompras, new frmCompras(usuarioActual));
        }

        private void subMenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuVentas, new frmDetalleVentas());
        }

        private void subMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            //frmDetalleCompras formDetalleCompra = new frmDetalleCompras();
            //formDetalleCompra.MdiParent = this;
            //formDetalleCompra.Show();
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

        //private void menuReportes_Click(object sender, EventArgs e)
        //{
        //    AbrirFormualrio((IconMenuItem)sender, new frmReportes());
        //}

        private void subMenuNegocio_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuMantenedor, new frmNegocio());
        }

        private void submenuReporteCompras_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuReportes, new frmReporteCompras());
        }

        private void submenuReporteVentas_Click(object sender, EventArgs e)
        {
            AbrirFormualrio(menuReportes, new frmReporteVentas());
        }
    }
}
