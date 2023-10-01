using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.HaberNesneler.Db
{
    public class HaberBolum
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik {get; set; }
        public string Resim { get; set; }
        public int HaberId { get; set; }
        public Haber Haber { get; set; }

    }   
}
