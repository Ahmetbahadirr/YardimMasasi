using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AltKonuNesneler.Db;
using YardimMasasi.Nesneler.EkipNesneler.Db;

namespace YardimMasasi.Nesneler.SurecNesneler.Db
{
    public class EkipAltKonu
    {
        public int EkipId { get; set; }
        public int AltKonuId { get; set; }
        public Ekip Ekip { get; set; }
        public AltKonu AltKonu { get; set; }
    }
}
