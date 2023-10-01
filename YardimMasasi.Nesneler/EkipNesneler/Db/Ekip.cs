using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.BirimNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.Nesneler.EkipNesneler.Db
{
    public class Ekip : DbBaseEntity
    {
        public Ekip()
        {
            AltKonular = new List<EkipAltKonu>();
        }
        public string Adi { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }
        public List<EkipAltKonu> AltKonular { get; set; }
    }
}
