using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.KullaniciNesneler.Dto;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IKullaniciService
    {
        public KullaniciDto KullaniciGetir(int id); 
    }
}
