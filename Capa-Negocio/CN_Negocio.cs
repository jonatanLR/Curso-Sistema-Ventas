using CapaDatos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CN_Negocio
    {
        // Objeto de la Clase Negocio (Capa de Datos)
        private CD_Negocio obj_cdNegocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return obj_cdNegocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio objNegocio, out string Mensaje)
        {
            Mensaje = string.Empty;

            //if (objUser.documento == string.Empty)
            //{
            //    Mensaje += "Es necesario el documento del Negocio\n";
            //}
            //if (objUser.nombreCompleto == string.Empty)
            //{
            //    Mensaje += "Es necesario el nombre del Negocio\n";
            //}
            //if (objUser.clave == string.Empty)
            //{
            //    Mensaje += "Es necesario la clave del Negocio\n";
            //}
            // Si el Mensaje es diferente de vacio entonces retorna 0 junto con los 
            // posibles errores
            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                // Si no hubo ningun error de validacion se ejecuta el return con 
                // el metodo Registrar del objeto capa de datos
                return obj_cdNegocio.GuardarDatos(objNegocio, out Mensaje);
            }

        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return obj_cdNegocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return obj_cdNegocio.ActualizarLogo(imagen, out mensaje);
        }
    }
}
