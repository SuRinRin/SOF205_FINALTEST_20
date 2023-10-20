using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class ThuCungCreateRequest
	{
		public string Ten { get; set; }
		public string Loai { get; set; }
		public string? Maulong { get; set; }
		public int? Tuoi { get; set; }
		public int? IdCn { get; set; }
	}
}
