namespace YardimMasasi.Nesneler.KullaniciNesneler.Db
{
    public class Rol
    {
        public Rol()
        {
            RolMenuler = new List<RolMenu>();
            RolKullanicilar = new List<KullaniciRol>();
        }
        public int Id { get; set; }
        public string RolAdi { get; set; }
        public List<RolMenu> RolMenuler { get; set; }
        public List<KullaniciRol> RolKullanicilar { get; set; }
    }
}
