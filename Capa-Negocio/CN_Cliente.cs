using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace Capa_Negocio
{
    public class CN_Cliente
    {
        // Objeto de la Clase Cliente (Capa de Datos)
        private CD_Cliente obj_cdCliente = new CD_Cliente();

        public List<Cliente> Listar()
        {
            return obj_cdCliente.Listar();
        }

        public int Registrar(Cliente objCliente, out string Mensaje)
        {
            Mensaje = string.Empty;

            //if (objCliente.documento == string.Empty)
            //{
            //    Mensaje += "Es necesario el documento del Cliente\n";
            //}
            //if (objCliente.nombreCompleto == string.Empty)
            //{
            //    Mensaje += "Es necesario el nombre del Cliente\n";
            //}
            //if (objCliente.clave == string.Empty)
            //{
            //    Mensaje += "Es necesario la clave del Cliente\n";
            //}
            //// Si el Mensaje es diferente de vacio entonces retorna 0 junto con los 
            //// posibles errores
            //if (Mensaje != string.Empty)
            //{
            //    return 0;
            //}
            //else
            //{
                // Si no hubo ningun error de validacion se ejecuta el return con 
                // el metodo Registrar del objeto capa de datos
                return obj_cdCliente.Registrar(objCliente, out Mensaje);
            //}


        }

        public bool Editar(Cliente objCliente, out string Mensaje)
        {
            Mensaje = string.Empty;

            //if (objCliente.documento == string.Empty)
            //{
            //    Mensaje += "Es necesario el documento del Cliente\n";
            //}
            //if (objCliente.nombreCompleto == string.Empty)
            //{
            //    Mensaje += "Es necesario el nombre del Cliente\n";
            //}
            //if (objCliente.clave == string.Empty)
            //{
            //    Mensaje += "Es necesario la clave del Cliente\n";
            //}
            //// Si el Mensaje es diferente de vacio entonces retorna false junto con los 
            //// posibles errores
            //if (Mensaje != string.Empty)
            //{
            //    return false;
            //}
            //else
            //{
                // Si no hubo ningun error de validacion se ejecuta el return con 
                // el metodo editar del objeto capa de datos
                return obj_cdCliente.Editar(objCliente, out Mensaje);
            //}

        }

        public bool Eliminar(Cliente objCliente, out string mensaje)
        {
            return obj_cdCliente.Eliminar(objCliente, out mensaje);
        }
    }
}
