using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.GorevNesneler.Db
{
    public class GorevMesaj
    {
        public int Id { get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
        public int MesajTuru { get; set; }
        public string Mesaj { get; set; }
        public DateTime MesajTarihi { get; set; }
        public int KullaniciId { get; set; }
        public int HedefKullaniciId { get; set; }
        public bool OkunduMu { get; set; }
    }
}
