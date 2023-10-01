using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.AltKonuNesneler;

namespace YardimMasasi.IsKatmani.Somut
{
    public class AltKonuService : IAltKonuService
    {
        public void AltKonuEkle(AltKonuEkleDto altKonu)
        {
            throw new NotImplementedException();
        }

        public AltKonuGuncelleDto AltKonuGuncelle(int id, AltKonuGuncelleDto altKonu)
        {
            throw new NotImplementedException();
        }

        public List<AltKonuListeElemaniDto> GetirAltKonuListe(int anaKonuId)
        {
            var liste = new List<AltKonuListeElemaniDto>();

            var k1 = new AltKonuListeElemaniDto();
            var k2 = new AltKonuListeElemaniDto();
            var k3 = new AltKonuListeElemaniDto();
            var k4 = new AltKonuListeElemaniDto();
            var k5 = new AltKonuListeElemaniDto();
            k1.Id = 1;
            k1.AnaKonuId = 1;
            k1.Adi = "Mesaj gelmiyor";
            k2.Id = 2;
            k2.AnaKonuId = 2;
            k2.Adi = "Şebeke çekmiyor";
            k3.Id = 3;
            k3.AnaKonuId = 3;
            k3.Adi = "Ayak uyuşukluğu ";
            k4.Id = 4;
            k4.AnaKonuId = 4;
            k4.Adi = "PC yavaş";
            k5.Id = 5;
            k5.AnaKonuId = 5;
            k5.Adi = "Gürültü geliyor";

            liste.AddRange(new[] { k1, k2, k3, k4, k5 });


            return liste.Where(x => x.AnaKonuId == anaKonuId).ToList();
        }

        public List<AltKonuListeElemaniDto> GetirAltKonuListe()
        {
            throw new NotImplementedException();
        }
    }
}
