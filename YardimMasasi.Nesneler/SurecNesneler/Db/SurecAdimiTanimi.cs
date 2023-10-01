using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.BirimNesneler.Db;

namespace YardimMasasi.Nesneler.SurecNesneler.Db
{
    public class SurecAdimiTanimi
    {
        public int Id { get; set; }
        public int Sira { get; set; }
        public int SurecTanimiId { get; set; }
        public SurecTanimi SurecTanimi { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }
    }
}
