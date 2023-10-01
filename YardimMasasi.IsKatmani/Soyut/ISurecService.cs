using YardimMasasi.Nesneler.GorevNesneler.Dto;
using YardimMasasi.Nesneler.SurecNesneler.Dto;
using YardimMasasi.VeriErisim;

namespace YardimMasasi.IsKatmani.Soyut
{
    public interface ISurecService
    {
        public void SurecBaslat(GorevCreateDto gorev);
        List<SurecTanimiListItemDto> GetSurecTanimlari();
    }
}
