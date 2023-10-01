using Microsoft.AspNetCore.Mvc.Rendering;

namespace YardimMasasi.Sunum.Models.GorevMesajViewModels
{
    public class GorevMesajCreateViewModel
    {
        public int GorevId { get; set; }
        public int Mesaj { get; set; }
        public int HedefKullaniciId { get; set; }
        public List<SelectListItem> HedefKullanicilar { get; set; } 

    }
}
