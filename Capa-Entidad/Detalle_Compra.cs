﻿namespace CapaEntidad
{
    public class Detalle_Compra
    {
        public int Id { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal montoTotal { get; set; }
        public string fechaRegistro { get; set; }

        public Producto oProducto { get; set; }
    }
}
