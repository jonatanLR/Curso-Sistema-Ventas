namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int Id { get; set; }
        public decimal precioVenta {  get; set; }
        public int Cantidad { get; set; }   
        public decimal subTotal { get; set; }
        public string fechaRegistro { get; set; }

        public Producto oProducto { get; set; }
    }
}
