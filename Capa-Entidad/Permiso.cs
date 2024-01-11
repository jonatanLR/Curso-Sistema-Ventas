using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int id {  get; set; }
        public string nombreMenu { get; set;}
        public string fechaRegistro { get; set;}
        public Rol oRol { get; set;}

    }
}
