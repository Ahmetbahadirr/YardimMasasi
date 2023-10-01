using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace YardimMasasi.Nesneler.KullaniciNesneler.Db
{
    public class Kullanici
    {
        public Kullanici()
        {
            KullaniciRoller = new List<KullaniciRol>();
        }
        public int Id { get; set; }
        public string Eposta { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public List<KullaniciRol> KullaniciRoller { get; set; }
    }
}
