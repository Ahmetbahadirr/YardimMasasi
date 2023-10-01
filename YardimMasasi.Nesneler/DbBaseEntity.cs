using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler
{
    public class DbBaseEntity
    {
        public int Id { get; set; }
        public DateTime OlusturmaTarihi { get; set; }= DateTime.Now;
        public bool Silindi { get; set; } = false;

    }
}
