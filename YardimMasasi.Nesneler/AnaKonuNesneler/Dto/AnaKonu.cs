using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.AnaKonuNesneler.Dto
{
    public class AnaKonuEkleDto : AnaKonuBaseDto
    {
    }
    public class AnaKonuBaseDto
    {
        public string Adi { get; set; }
    }
    public class AnaKonuGuncelleDto : AnaKonuBaseDto
    {
        public int Id { get; set; }
    }
    public class AnaKonuListeElemaniDto : AnaKonuBaseDto
    {
        public int Id { get; set; }
        public string Konu { get; set; }
    }

}
