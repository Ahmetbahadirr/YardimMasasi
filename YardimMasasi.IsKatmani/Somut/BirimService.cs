using YardimMasasi.IsKatmani.Soyut;
using YardimMasasi.Nesneler.BirimNesneler;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;
using YardimMasasi.VeriErisim;

namespace YardimMasasi.IsKatmani.Somut
{
    public class BirimService : IBirimService
    {
        public void BirimEkle(BirimEkleDto birim)
        {
            throw new NotImplementedException();
        }

        public BirimGuncelleDto BirimGuncelle(int id, BirimGuncelleDto birimGuncelle)
        {
            throw new NotImplementedException();
        }

        public BirimGuncelleDto BirimGuncelle(int id)
        {
            throw new NotImplementedException();
        }

        public List<BirimListeElemaniDto> GetirBirimListe()
        {
            using (var c = new YardimMasasiContext())
            {
                var liste = c.Birimler.Select(a => new BirimListeElemaniDto
                {
                    Id = a.Id,
                    Adi = a.Adi                  
                });
                return liste.ToList();
            }
        }
    }
}
