using YardimMasasi.Nesneler.AltKonuNesneler;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IAltKonuService
    {
        public void AltKonuEkle(AltKonuEkleDto altKonu);

        public AltKonuGuncelleDto AltKonuGuncelle(int id, AltKonuGuncelleDto altKonu);
        public List<AltKonuListeElemaniDto> GetirAltKonuListe();
        public List<AltKonuListeElemaniDto> GetirAltKonuListe(int anaKonuId);
    }
}
