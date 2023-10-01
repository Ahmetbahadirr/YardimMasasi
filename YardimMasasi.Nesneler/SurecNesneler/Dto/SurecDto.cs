using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.SurecNesneler.Dto
{
    public class SurecDto
    {
        public int Id { get; set; }
        public int GorevId { get; set; }
        public List<SurecAdimiDto> Adimlar { get; set; }
    }
}
