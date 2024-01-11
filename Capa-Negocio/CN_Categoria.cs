using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Categoria
    {
        // Objeto de la Clase Categoria (Capa de Datos)
        private CD_Categoria obj_cdCategoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return obj_cdCategoria.Listar();
        }

        public int Registrar(Categoria objCategoria, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (objCategoria.descripcion == string.Empty)
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
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
                return obj_cdCategoria.Registrar(objCategoria, out Mensaje);
            }


        }

        public bool Editar(Categoria objCategoria, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (objCategoria.descripcion == string.Empty)
            {
                Mensaje += "Es necesario la descripcion de la Categoria\n";
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
                return obj_cdCategoria.Editar(objCategoria, out Mensaje);
            }

        }

        public bool Eliminar(Categoria objCategoria, out string mensaje)
        {
            return obj_cdCategoria.Eliminar(objCategoria, out mensaje);
        }
    }
}
