using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CapaEntidad
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Documento {  get; set; }

        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        [Phone]
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
