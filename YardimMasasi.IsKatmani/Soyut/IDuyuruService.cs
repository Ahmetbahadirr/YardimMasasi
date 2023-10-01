using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YardimMasasi.Nesneler.DuyuruNesneler;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using static YardimMasasi.IsKatmani.Somut.DuyuruService;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IDuyuruService
    {
        public void DuyuruEkle(DuyuruEkleDto duyuru);
        public DuyuruDto DuyuruGuncelle(int id, DuyuruDto duyuru);
        public List<DuyuruListeElemaniDto> GetirDuyuruListe();
        public DuyuruGuncelleDto GetirDuyuruGuncelle(int id);
    }
}
