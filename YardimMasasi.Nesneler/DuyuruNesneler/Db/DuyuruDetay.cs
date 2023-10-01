using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.DuyuruNesneler.Db
{
    public class DuyuruDetay
    {
        public int Id { get; set; }
        public int DuyuruId { get; set; }
        public Duyuru Duyuru { get; set; }
        public int MaddeNo { get; set; }
        public int Sıra { get; set; }
        public string Metin { get; set; }

    }
}

