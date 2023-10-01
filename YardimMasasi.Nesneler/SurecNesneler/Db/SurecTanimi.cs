using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AltKonuNesneler.Db;

namespace YardimMasasi.Nesneler.SurecNesneler.Db
{
    public class SurecTanimi
    {
        public SurecTanimi()
        {
            this.SurecAdimlari = new List<SurecAdimiTanimi>();
            this.Surecler = new List<Surec>();
        }
        public int Id { get; set; }
        public string Adi { get; set; }
        public List<AltKonu> AltKonular { get; set; }
        public List<SurecAdimiTanimi> SurecAdimlari { get; set; }
        public List<Surec> Surecler { get; set; }
    }
}
