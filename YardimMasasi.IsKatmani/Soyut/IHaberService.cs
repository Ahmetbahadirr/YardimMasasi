using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;
using YardimMasasi.Nesneler.HaberNesneler.Dto;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IHaberService
    {
        public void HaberEkle(HaberEkleDto haber);
        public HaberGuncelleDto HaberGuncelle(int id, HaberGuncelleDto haber);
        public List<HaberListeElemaniDto> GetirHaberListe();

        HaberGuncelleDto HaberGetir(int id);

        public void HaberBolumEkle(HaberBolumEkleDto haberBolum);
        public HaberBolumGuncelleDto HaberBolumGuncelle(int id, HaberBolumGuncelleDto haberBolum);
        public List<HaberBolumListeElemaniDto> GetirHaberBolumListe();

    }

}
