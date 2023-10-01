using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.BirimNesneler.Db;
using YardimMasasi.Nesneler.GorevNesneler.Db;

namespace YardimMasasi.Nesneler.SurecNesneler.Db
{
    public class Surec
    {
        public int Id { get; set; }
        public Gorev Gorev  { get; set; }
        public int Sira { get; set; }
        public int SurecTanimiId { get; set; }
        public SurecTanimi SurecTanimi { get; set; }
        public List<SurecAdimi> SurecAdimlari { get; set; }
    }
}
