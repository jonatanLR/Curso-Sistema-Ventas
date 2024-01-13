namespace CapaEntidad
{
    public class Cliente
    {
        public int Id { get; set; }
        public string documento {  get; set; }
        public string nombreCompleto { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fechaRegistro { get; set; }
    }
}
