using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.GorevNesneler.Db
{
    public class GorevIslem
    {
        public int Id { get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
        public int IslemTuru { get; set; }
        public string Acıklama { get; set; }
        public DateTime IslemTarihi { get; set; }
        public int HedefKullaniciId { get; set; }
    }
}
