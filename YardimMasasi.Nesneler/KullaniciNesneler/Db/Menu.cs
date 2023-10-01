namespace YardimMasasi.Nesneler.KullaniciNesneler.Db
{
    public class Menu
    {
        public Menu()
        {
            MenuRoller = new List<RolMenu>();
        }
        public int Id { get; set; }
        public string HtmlClass { get; set; }
        public string IconUrl { get; set; }
        public string Url { get; set; }
        public List<RolMenu> MenuRoller { get; set; }
    }
}
