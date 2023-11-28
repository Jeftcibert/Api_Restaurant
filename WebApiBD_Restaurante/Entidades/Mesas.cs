namespace WebApiBD_Restaurante.Entidades
{
    public class Mesas
    {
        public int Id { get; set; }
        public int numero { get; set; }
        public int numero_sillas { get; set; }
        public string? posicion { get; set; }
        public int estado { get; set; }

        public string? descripcion { get; set; }
    }
}
