using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.EkipNesneler.Db;
using YardimMasasi.Nesneler.SurecNesneler.Db;

namespace YardimMasasi.Nesneler.BirimNesneler.Db
{
    public class Birim : DbBaseEntity
    {
        public Birim()
        {
            Ekipler=new List<Ekip>();
            SurecAdimTanimlari = new List<SurecAdimiTanimi>();
            SurecAdimlari = new List<SurecAdimi>();
        }
        public string Adi { get; set; }
        public List<Ekip> Ekipler { get; set; }
        public List<SurecAdimiTanimi> SurecAdimTanimlari { get; set; }
        public List<SurecAdimi> SurecAdimlari { get; set; }
    }
}
