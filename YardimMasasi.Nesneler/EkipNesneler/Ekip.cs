using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.EkipNesneler
{
    public class EkipEkleDto : EkipBaseDto
    {

    }
    public class EkipBaseDto
    {

        public string Adi { get; set; }
        public string BirimAdi { get; set; }
    }
    public class EkipGuncelleDto : EkipBaseDto
    {
        public int Id { get; set; }
    }
    public class EkipListeElemaniDto : EkipBaseDto
    {
        public int Id { get; set; }
    }
}
