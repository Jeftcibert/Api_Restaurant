 namespace WebApiBD_Restaurante.Entidades
{
    public class Usuario
    {

        public int id { get; set; }
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }  
        public int? rol { get; set; }
       
    }
}
