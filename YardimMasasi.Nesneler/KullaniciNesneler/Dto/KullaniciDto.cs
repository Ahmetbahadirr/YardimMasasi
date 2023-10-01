using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace YardimMasasi.Nesneler.KullaniciNesneler.Dto
{
    public class KullaniciDto
    {
        public KullaniciDto()
        {
            this.Roller = new List<RolDto>();
        }
        public int Id { get; set; }
        public string Eposta { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public List<RolDto> Roller { get; set; }
    }
}
