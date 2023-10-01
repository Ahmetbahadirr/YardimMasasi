using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.HaberNesneler.Db
{

    public class Haber
    {
        public Haber()
        {
            Bolumler = new List<HaberBolum>();
        }

        public int Id { get; set; }

        public string Baslik { get; set; }   
        
        public string Icerik { get; set; }

        public DateTime YayinTarihi { get; set; }

        public List<HaberBolum> Bolumler { get; set; }


    }




}
