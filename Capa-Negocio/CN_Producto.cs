using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Producto
    {
        // Objeto de la Clase Producto (Capa de Datos)
        private CD_Producto obj_cdProducto = new CD_Producto();

        public List<Producto> Listar()
        {
            return obj_cdProducto.Listar();
        }

        public int Registrar(Producto objProducto, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (objProducto.codigo == string.Empty)
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }
            if (objProducto.nombre == string.Empty)
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }
            if (objProducto.descripcion == string.Empty)
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
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
                return obj_cdProducto.Registrar(objProducto, out Mensaje);
            }


        }

        public bool Editar(Producto objProducto, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (objProducto.codigo == string.Empty)
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }
            if (objProducto.nombre == string.Empty)
            {
                Mensaje += "Es necesario el nombre del Producto\n";
            }
            if (objProducto.descripcion == string.Empty)
            {
                Mensaje += "Es necesario la descripcion del Producto\n";
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
                return obj_cdProducto.Editar(objProducto, out Mensaje);
            }

        }

        public bool Eliminar(Producto objProducto, out string mensaje)
        {
            return obj_cdProducto.Eliminar(objProducto, out mensaje);
        }
    }
}
