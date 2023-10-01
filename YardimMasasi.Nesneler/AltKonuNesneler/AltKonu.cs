using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.AltKonuNesneler
{
    public class AltKonuEkleDto : AltKonuBaseDto
    {

    }

    public class AltKonuBaseDto
    {
        public string Adi { get; set; }
        public string AnaKonuAdi { get; set; }
    }
    public class AltKonuGuncelleDto : AltKonuBaseDto
    {
        public int Id { get; set; }
    }
    public class AltKonuListeElemaniDto : AltKonuBaseDto
    {
        public int Id { get; set; }
        public int AnaKonuId { get; set; }
    }
}

