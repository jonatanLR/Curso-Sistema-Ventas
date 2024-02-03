namespace CapaEntidad
{
    public class Producto
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set;}

        public string descripcion { get; set;}
        public int stock { get; set; }
        public decimal precioCompra {  get; set; }

        public decimal precioVenta { get; set; }
        public bool estado {  get; set; }
        public string fechaRegistro { get; set; }

        public Categoria oCategoria {  get; set; }
    }
}
