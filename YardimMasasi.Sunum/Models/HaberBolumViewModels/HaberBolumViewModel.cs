using YardimMasasi.Sunum.Models.HaberViewModels;

namespace YardimMasasi.Sunum.Models.HaberBolumViewModels
{
    public class HaberBolumBaseViewModel
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
        public DateTime YayinTarihi { get; set; }

    }
    public class HaberBolumCreateViewModel : HaberBolumBaseViewModel
    {
        
    }
    public class HaberBolumDetailsViewModel :HaberBolumBaseViewModel
    {

    }
    public class HaberBolumListItemViewModel : HaberBolumBaseViewModel
    {
        public int Id { get; set; }
    }

    public class HaberBolumUpdateViewModel : HaberBolumBaseViewModel
    {
        public int Id { get; set; }
    }



}
