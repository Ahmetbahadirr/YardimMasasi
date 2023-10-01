using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.GorevNesneler
{
    public class GorevEkleDto : GorevBaseDto
    {

    }
    public class GorevBaseDto
    {
        public int Adi { get; set; }
    }
    public class GorevGuncelleDto : GorevBaseDto
    {
        public int Id { get; set; }
    }
    public class GorevListeElemaniDto : GorevBaseDto
    {
        public int Id { get; set; }
    }
}
