namespace CapaEntidad
{
    public class Venta
    {
        public int Id { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get;set; }
        public decimal montoPago { get; set; }
        public decimal montoCambio { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaRegistro { get; set; }

        public Categoria oUsuario { get; set; }
    }
}
