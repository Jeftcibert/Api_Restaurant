namespace WebApiBD_Restaurante.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get;set; }
        public int documento { get; set; }
        public int nroDocumento { get; set; }
        public string? direccion { get; set; }
        public int telefono { get; set; }
        public string? correo { get; set; }
    }
}
