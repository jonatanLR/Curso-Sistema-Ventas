using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Venta
    {
        private CD_Venta obj_cdVenta = new CD_Venta();

        public bool RestarStock(int idProducto, int cantidad)
        {
            return obj_cdVenta.RestarStock(idProducto, cantidad);
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            return obj_cdVenta.SumarStock(idProducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return obj_cdVenta.ObtenerCorrelativo();
        }

        public bool Registrar(Venta objVenta, DataTable detalleVenta, out string Mensaje)
        {
            return obj_cdVenta.Registrar(objVenta, detalleVenta, out Mensaje);
        }

        public Venta ObtenerVenta(string numero)
        {
            // obtenemos la compra pasandole el numero de compra
            Venta oVenta = obj_cdVenta.ObtenerVenta(numero);

            // si el numero de compra es valido o diferente a cero
            if (oVenta.Id != 0)
            {
                // entonces procedemos a obtener el detalle de la compra pasandole el ID del objeto Compra
                List<Detalle_Venta> oDetalleVenta = obj_cdVenta.ObtenerDetalleVenta(oVenta.Id);

                // asignamos el objetoDC al detalle compra de la compra
                oVenta.oDetalle_Venta = oDetalleVenta;
            }

            return oVenta;
        }
    }
}
