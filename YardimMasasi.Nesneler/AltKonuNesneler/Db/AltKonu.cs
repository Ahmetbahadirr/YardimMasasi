using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AnaKonuNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.Nesneler.AltKonuNesneler.Db
{
    public class AltKonu : DbBaseEntity
    {
        public AltKonu()
        {
            Ekipler = new List<EkipAltKonu>();
        }
        public string Tanim { get; set; }
        public int AnaKonuId { get; set; }
        public AnaKonu AnaKonu { get; set;}
        public int? SurecTanimiId { get; set; }
        public SurecTanimi SurecTanimi { get; set; }
        public List<EkipAltKonu> Ekipler { get; set; }
    }
}
