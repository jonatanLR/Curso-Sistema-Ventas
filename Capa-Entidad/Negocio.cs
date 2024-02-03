using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Negocio
    {
        public int Id {  get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string RUC { get; set;}

        [Required]
        public string Direccion { get; set;}
    }
}
