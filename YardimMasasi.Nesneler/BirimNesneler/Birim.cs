using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.BirimNesneler
{
    public class BirimEkleDto : BirimBaseDto
    {
    }

    public class BirimBaseDto
    {

        public string Adi { get; set; }
    }

    public class BirimGuncelleDto : BirimBaseDto
    {
        public int Id { get; set; }
    }

    public class BirimListeElemaniDto : BirimBaseDto
    {
        public int Id { get; set; }
    }
}
