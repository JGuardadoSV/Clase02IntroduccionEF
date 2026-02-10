namespace Clase02IntroduccionEF
{
    public class DetalleCompra
    {
        public int Id { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        // Relación con Compra
        public int CompraId { get; set; }
        public virtual Compra Compra { get; set; }
    }
}
