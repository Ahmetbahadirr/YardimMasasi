namespace YardimMasasi.Sunum.Models.DuyuruViewModels
{
    public class DuyuruGuncelleViewModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Konu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
    }
}
