using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.HaberNesneler.Dto
{

    public class HaberEkleDto : HaberBaseDto
    {
        public HaberEkleDto()
        {
            this.Bolumler = new List<HaberBolumEkleDto>();
        }
        public DateTime YayinTarihi { get; set; }
        public string Icerik { get; set; }
        public List<HaberBolumEkleDto> Bolumler { get; set; }
    }
    public class HaberBaseDto
    {
        public string Baslik { get; set; }
    }
    public class HaberGuncelleDto : HaberBaseDto
    {
        public int Id { get; set; }
        public DateTime YayinTarihi { get; set; }
        public string Icerik { get; set; }
    }
    public class HaberListeElemaniDto : HaberBaseDto
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime YayinTarihi { get; set; }
    }

}



