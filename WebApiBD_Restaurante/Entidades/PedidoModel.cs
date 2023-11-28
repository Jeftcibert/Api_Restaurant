namespace WebApiBD_Restaurante.Entidades
{
    public class PedidoModel
    {
        public int id { get; set; }
        public string? Nombre { get; set; }
        public Decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public decimal Importe
        {
            get
            {
                return Precio * Cantidad;
            }
        }
    }
}
