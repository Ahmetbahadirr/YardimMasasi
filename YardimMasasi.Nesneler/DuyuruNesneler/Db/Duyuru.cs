using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.DuyuruNesneler.Db
{
    public class Duyuru
    {
        public Duyuru()
        {
            Detaylar = new List<DuyuruDetay>();
        }
        public int Id { get; set; } 
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string Metin { get; set; }
        public string Baslik { get; set; }

     
        public List<DuyuruDetay> Detaylar { get; set; }
    }
}
