using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.DuyuruNesneler.Dto
{
    public class DuyuruDto
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Konu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }

    public class DuyuruListeElemaniDto
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Konu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
    }

    public class DuyuruEkleDto
    {

        public string Baslik { get; set; }
        public string Konu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }


    }
    public class DuyuruGuncelleDto
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Konu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
    }
}
