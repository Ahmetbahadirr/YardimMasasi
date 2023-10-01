using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.GorevNesneler.Dto
{
    public class GorevDto
    {
        public string Email { get; set; }
        public int AltKonuId { get; set; }
    }

    public class GorevCreateDto : GorevDto
    {

    }
}
