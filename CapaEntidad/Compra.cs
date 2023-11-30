using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int Id { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaRegistro { get; set; }
        public Usuario oUsuario { get; set;}
        public Proveedor oProveedor { get; set; }

        public List<Detalle_Compra> oDetalle_compra { get; set; }
    }
}
