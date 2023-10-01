using YardimMasasi.Nesneler.BirimNesneler;
using YardimMasasi.Nesneler.DuyuruNesneler.Dto;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IBirimService
    {
        public void BirimEkle(BirimEkleDto birim);
        public BirimGuncelleDto BirimGuncelle(int id, BirimGuncelleDto birimGuncelle);
        public List<BirimListeElemaniDto> GetirBirimListe();
        public BirimGuncelleDto BirimGuncelle(int id);
    }
}
