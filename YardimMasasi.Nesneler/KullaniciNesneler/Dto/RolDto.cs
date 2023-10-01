namespace YardimMasasi.Nesneler.KullaniciNesneler.Dto
{
    public class RolDto
    {
        public RolDto()
        {
            Menuler = new List<MenuDto>();
        }
        public int Id { get; set; }
        public string RolAdi { get; set; }
        public List<MenuDto> Menuler { get; set; }
    }
}
