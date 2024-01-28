using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Compra
    {
        private CD_Compra obj_CD_Compra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return obj_CD_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compra objCompra, DataTable detalleCompra, out string Mensaje)
        {
            return obj_CD_Compra.Registrar(objCompra, detalleCompra, out Mensaje);
        }

        public Compra ObtenerCompra(string numero)
        {
            // obtenemos la compra pasandole el numero de compra
            Compra oCompra = obj_CD_Compra.ObtenerCompra(numero);

            // si el numero de compra es valido o diferente a cero
            if (oCompra.Id != 0)
            {
                // entonces procedemos a obtener el detalle de la compra pasandole el ID del objeto Compra
                List<Detalle_Compra> oDetalleCompra = obj_CD_Compra.ObtenerDetalleCompra(oCompra.Id);

                // asignamos el objetoDC al detalle compra de la compra
                oCompra.oDetalle_compra = oDetalleCompra;
            }

            return oCompra;
        }
    }
}
