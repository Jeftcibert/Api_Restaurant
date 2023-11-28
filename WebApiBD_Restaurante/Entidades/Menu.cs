namespace WebApiBD_Restaurante.Entidades
{
    public partial class Menu
    {
        public Menu()
        {
            IdSubMenus = new HashSet<Menu>();
        }

        public int? IdMenu { get; set; }

        public int? Tipo { get; set; }
        public string? descripcion { get; set; }
        public int? IdsubMenuId { get; set; }
        public string? urlAction { get; set; }
        public string? urlController { get; set; }
        public virtual Menu? IdsubMenu { get; set; }

        public virtual ICollection<Menu> IdSubMenus { get; set; }
    }
}
