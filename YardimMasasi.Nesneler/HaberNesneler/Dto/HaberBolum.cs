using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.HaberNesneler.Dto
{
    public class HaberBolumEkleDto : HaberBolumBaseDto
    {
    }
    public class HaberBolumBaseDto
    {
        public string Baslik { get; set; }
        public string Resim { get; set; }
        public string Icerik { get; set; }
    }
    public class HaberBolumGuncelleDto : HaberBolumBaseDto
    {
        public int Id { get; set; }
    }
    public class HaberBolumListeElemaniDto : HaberBolumBaseDto
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
    }


}
