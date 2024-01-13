using System.Collections.Generic;

namespace CapaEntidad
{
    public class Compra
    {
        public int Id { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaRegistro { get; set; }
        public Categoria oUsuario { get; set;}
        public Proveedor oProveedor { get; set; }

        public List<Detalle_Compra> oDetalle_compra { get; set; }
    }
}
