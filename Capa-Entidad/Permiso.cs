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
