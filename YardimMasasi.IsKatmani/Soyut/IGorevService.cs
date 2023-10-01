using YardimMasasi.Nesneler.GorevNesneler;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface IGorevService
    {
        public void GorevEkle(GorevEkleDto gorev);
        public GorevGuncelleDto GorevGuncelle(int id, GorevGuncelleDto gorev);
        public List<GorevListeElemaniDto> GetirGorevListe();
    }
}
