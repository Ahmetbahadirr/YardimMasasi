namespace YardimMasasi.Nesneler.KullaniciNesneler.Db
{
    public class RolMenu
    {
        public int RolId { get; set; }
        public int MenuId { get; set; }
        public Rol Rol { get; set; }
        public Menu Menu { get; set; }
    }
}
