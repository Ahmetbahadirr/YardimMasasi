using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.AnaKonuNesneler.Dto;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.VeriErisim;

namespace YardimMasasi.IsKatmani.Somut
{
    public class AnaKonuService : IAnaKonuService
    {
        public void AnaKonuEkle(AnaKonuEkleDto anaKonu)
        {
            throw new NotImplementedException();
        }

        public AnaKonuGuncelleDto AnaKonuGuncelle(int id, AnaKonuGuncelleDto anaKonu)
        {
            throw new NotImplementedException();
        }

        public AnaKonuGuncelleDto GetirAnaKonu(int id)
        {
            using (var c = new YardimMasasiContext())
            {
                var nesne = c.AnaKonular.FirstOrDefault(a => a.Id == id);
                return new AnaKonuGuncelleDto
                {
                    Id= nesne.Id,
                    Adi = nesne.Tanim
                };
            }
        }

        public List<AnaKonuListeElemaniDto> GetirAnaKonuListe()
        {
            using (var c = new YardimMasasiContext())
            {
                var liste = c.AnaKonular.Select(a => new AnaKonuListeElemaniDto
                {
                    Id = a.Id,
                    Adi = a.Tanim
                });
                return liste.ToList();
            }
        }
    }
}
