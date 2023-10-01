using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardimMasasi.Nesneler.GorevMesajNesneler.Dto
{
	public class GorevMesaj
	{
		
		public class GorevMesajCreateDto
		{
			public int Mesaj { get; set; }
		}

		public class GorevMesajGuncelleDto : GorevMesajCreateDto
		{
			public int GorevId { get; set; }
		}
		

	}
}
