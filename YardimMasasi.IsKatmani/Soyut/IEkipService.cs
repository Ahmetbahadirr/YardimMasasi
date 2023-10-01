using YardimMasasi.Nesneler.EkipNesneler.Dto;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IEkipService
    {
        public void EkipEkle(EkipEkleDto ekip);
        public EkipGuncelleDto EkipGuncelle(int id, EkipGuncelleDto ekip);
        public List<EkipListeElemaniDto> GetirEkipListe();
    }
}
