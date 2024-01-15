using System.ComponentModel.DataAnnotations;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required]
        public string Documento { get; set; }

        [Required]
        public string RazonSocial { get; set; }

        [Required]
        [EmailAddress]
        public string Correo {  get; set; }

        [Required]
        [Phone]
        public string Telefono { get; set; }
        public bool Estado {  get; set; }
        public string FechaRegistro { get; set; }
    }
}
