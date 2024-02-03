using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Proveedor
    {
        // Objeto de la Clase Proveedor (Capa de Datos)
        private CD_Proveedor obj_cdProveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return obj_cdProveedor.Listar();
        }

        public int Registrar(Proveedor objProveedor, out string Mensaje)
        {
            Mensaje = string.Empty;

            return obj_cdProveedor.Registrar(objProveedor, out Mensaje);            
        }

        public bool Editar(Proveedor objProveedor, out string Mensaje)
        {
            Mensaje = string.Empty;

            return obj_cdProveedor.Editar(objProveedor, out Mensaje);
        }

        public bool Eliminar(Proveedor objProveedor, out string mensaje)
        {
            return obj_cdProveedor.Eliminar(objProveedor, out mensaje);
        }
    }
}
