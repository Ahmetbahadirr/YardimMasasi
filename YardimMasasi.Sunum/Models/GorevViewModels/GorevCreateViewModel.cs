using Microsoft.AspNetCore.Mvc.Rendering;

namespace YardimMasasi.Sunum.Models.GorevViewModels
{
    public class GorevCreateViewModel: GorevBaseViewModel
    {
        public List<SelectListItem> Konular { get; set; }
        public List<SelectListItem> AltKonular { get; set; }
    }
}
