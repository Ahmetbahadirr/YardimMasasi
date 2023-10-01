using Microsoft.AspNetCore.Mvc.Rendering;

namespace YardimMasasi.Sunum.Models.SurecViewModels
{
    public class SurecAdimiTanimiCreateViewModel
    {
        public int Sira { get; set; }
        public int BirimId { get; set; }
        public int SurecTanimiId { get; set; }
        public List<SelectListItem> Birimler { get; set; }
    }
}
