using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
	public class ThuCungDTO
	{
		public int STT { get; set; }
		public string Ten { get; set; }
		public string Loai { get; set; }
		public string? Maulong { get; set; }
		public int? Tuoi { get; set; }
		public string? Diachi { get; set; }

		public int? IdTc { get; set; }
	}
}
