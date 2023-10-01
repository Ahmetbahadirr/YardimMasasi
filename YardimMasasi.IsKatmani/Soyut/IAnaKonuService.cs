using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IAnaKonuService
    {
        public void AnaKonuEkle(AnaKonuEkleDto anaKonu);
        public AnaKonuGuncelleDto AnaKonuGuncelle(int id, AnaKonuGuncelleDto anaKonu);
        public AnaKonuGuncelleDto GetirAnaKonu(int id);
        public List<AnaKonuListeElemaniDto> GetirAnaKonuListe();

    }


}
