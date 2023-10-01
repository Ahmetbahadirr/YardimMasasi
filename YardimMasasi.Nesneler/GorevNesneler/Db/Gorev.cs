using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.Nesneler.GorevNesneler.Db
{
    public class Gorev
    {
        public int Id { get; set; }
        public Surec Surec { get; set; }
        public int AltKonuId { get; set; }
        public int BirimId { get; set; }
        public int TalepSahibiId { get; set; }
        public int TeknisyenId { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime OluşturulmaTarihi { get; set; }
        public DateTime SonİslemTarihi { get; set; }
        public List<GorevIslem> Islemler { get; set; }
        public List<GorevMesaj> Mesajlar { get; set; }
    }
}
