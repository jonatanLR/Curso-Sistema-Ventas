using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace Capa_Negocio
{
    public class CN_Usuario
    {
        // Objeto de la Clase Usuario (Capa de Datos)
        private CD_Usuario obj_cdUsuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return obj_cdUsuario.Listar();
        }

        public int Registrar(Usuario objUser, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (objUser.documento == string.Empty)
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }
            if (objUser.nombreCompleto == string.Empty)
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }
            if (objUser.clave == string.Empty)
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }
            // Si el Mensaje es diferente de vacio entonces retorna 0 junto con los 
            // posibles errores
            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                // Si no hubo ningun error de validacion se ejecuta el return con 
                // el metodo Registrar del objeto capa de datos
                return obj_cdUsuario.Registrar(objUser, out Mensaje);
            }

            
        }

        public bool Editar(Usuario objUser, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (objUser.documento == string.Empty)
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }
            if (objUser.nombreCompleto == string.Empty)
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }
            if (objUser.clave == string.Empty)
            {
                Mensaje += "Es necesario la clave del usuario\n";
            }
            // Si el Mensaje es diferente de vacio entonces retorna false junto con los 
            // posibles errores
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                // Si no hubo ningun error de validacion se ejecuta el return con 
                // el metodo editar del objeto capa de datos
                return obj_cdUsuario.Editar(objUser, out Mensaje);
            }
            
        }

        public bool Eliminar(Usuario objUser, out string mensaje)
        {
            return obj_cdUsuario.Eliminar(objUser, out mensaje);
        }
    }
}
