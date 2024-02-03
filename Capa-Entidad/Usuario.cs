namespace CapaEntidad
{
    public class Usuario
    {
        public int Id { get; set; }
        public string documento { get; set; }
        public string nombreCompleto { get; set;}
        public string correo { get; set;}
        public string clave { get; set;}
        public bool estado { get; set;}
        public string fechaRegistro { get; set; }
        public Rol oRol { get; set;}
    }
}
