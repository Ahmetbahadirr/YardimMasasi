using YardimMasasi.Sunum.Models.HaberBolumViewModels;

namespace YardimMasasi.Sunum.Models.HaberViewModels
{
    public class HaberBaseViewModel
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime YayinTarihi { get; set; }
    }
    public class HaberCreateViewModel : HaberBaseViewModel
    {
        public List<HaberBolumCreateViewModel> Bolumler { get; set; }
    }

    public class HaberDetailsViewModel
    {

    }
    public class HaberListItemViewModel:HaberBaseViewModel
    {
        public int Id { get; set; }
    }

    public class HaberUpdateViewModel:HaberBaseViewModel
    {
        public int Id { get; set; }
    }
}
