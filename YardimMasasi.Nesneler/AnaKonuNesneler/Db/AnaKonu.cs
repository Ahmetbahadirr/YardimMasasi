using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AltKonuNesneler.Db;

namespace YardimMasasi.Nesneler.AnaKonuNesneler.Db
{
    public class AnaKonu : DbBaseEntity
    {
        public AnaKonu()
        {
            AltKonular=new List<AltKonu>();
        }
        public string Tanim { get; set; }
        public List<AltKonu> AltKonular { get; set; }

    }
}
